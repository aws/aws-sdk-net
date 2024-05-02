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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the InvokeWithResponseStream operation.
    /// Configure your Lambda functions to stream response payloads back to clients. For more
    /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-response-streaming.html">Configuring
    /// a Lambda function to stream responses</a>.
    /// 
    ///  
    /// <para>
    /// This operation requires permission for the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/list_awslambda.html">lambda:InvokeFunction</a>
    /// action. For details on how to set up permissions for cross-account invocations, see
    /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/access-control-resource-based.html#permissions-resource-xaccountinvoke">Granting
    /// function access to other accounts</a>.
    /// </para>
    /// </summary>
    public partial class InvokeWithResponseStreamRequest : AmazonLambdaRequest
    {
        private string _clientContext;
        private string _functionName;
        private ResponseStreamingInvocationType _invocationType;
        private LogType _logType;
        private MemoryStream _payload;
        private string _qualifier;

        /// <summary>
        /// Gets and sets the property ClientContext. 
        /// <para>
        /// Up to 3,583 bytes of base64-encoded data about the invoking client to pass to the
        /// function in the context object.
        /// </para>
        /// </summary>
        public string ClientContext
        {
            get { return this._clientContext; }
            set { this._clientContext = value; }
        }

        // Check to see if ClientContext property is set
        internal bool IsSetClientContext()
        {
            return this._clientContext != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function.
        /// </para>
        ///  
        /// <para>
        ///  <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> – <c>my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> – <c>arn:aws:lambda:us-west-2:123456789012:function:my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> – <c>123456789012:function:my-function</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
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
        /// Use one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RequestResponse</c> (default) – Invoke the function synchronously. Keep the connection
        /// open until the function returns a response or times out. The API operation response
        /// includes the function response and additional data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DryRun</c> – Validate parameter values and verify that the IAM user or role has
        /// permission to invoke the function.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResponseStreamingInvocationType InvocationType
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
        /// Set to <c>Tail</c> to include the execution log in the response. Applies to synchronously
        /// invoked functions only.
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
        /// Gets and sets the property Payload. 
        /// <para>
        /// The JSON that you want to provide to your Lambda function as input.
        /// </para>
        ///  
        /// <para>
        /// You can enter the JSON directly. For example, <c>--payload '{ "key": "value" }'</c>.
        /// You can also specify a file path. For example, <c>--payload file://payload.json</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public MemoryStream Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// The alias name.
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