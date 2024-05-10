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
    /// This is the response object from the CreateFunctionUrlConfig operation.
    /// </summary>
    public partial class CreateFunctionUrlConfigResponse : AmazonWebServiceResponse
    {
        private FunctionUrlAuthType _authType;
        private Cors _cors;
        private string _creationTime;
        private string _functionArn;
        private string _functionUrl;
        private InvokeMode _invokeMode;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The type of authentication that your function URL uses. Set to <c>AWS_IAM</c> if you
        /// want to restrict access to authenticated users only. Set to <c>NONE</c> if you want
        /// to bypass IAM authentication to create a public endpoint. For more information, see
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/urls-auth.html">Security and
        /// auth model for Lambda function URLs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FunctionUrlAuthType AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property Cors. 
        /// <para>
        /// The <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS">cross-origin
        /// resource sharing (CORS)</a> settings for your function URL.
        /// </para>
        /// </summary>
        public Cors Cors
        {
            get { return this._cors; }
            set { this._cors = value; }
        }

        // Check to see if Cors property is set
        internal bool IsSetCors()
        {
            return this._cors != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the function URL was created, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of your function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionUrl. 
        /// <para>
        /// The HTTP URL endpoint for your function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=40, Max=100)]
        public string FunctionUrl
        {
            get { return this._functionUrl; }
            set { this._functionUrl = value; }
        }

        // Check to see if FunctionUrl property is set
        internal bool IsSetFunctionUrl()
        {
            return this._functionUrl != null;
        }

        /// <summary>
        /// Gets and sets the property InvokeMode. 
        /// <para>
        /// Use one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BUFFERED</c> – This is the default option. Lambda invokes your function using
        /// the <c>Invoke</c> API operation. Invocation results are available when the payload
        /// is complete. The maximum payload size is 6 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESPONSE_STREAM</c> – Your function streams payload results as they become available.
        /// Lambda invokes your function using the <c>InvokeWithResponseStream</c> API operation.
        /// The maximum response payload size is 20 MB, however, you can <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">request
        /// a quota increase</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InvokeMode InvokeMode
        {
            get { return this._invokeMode; }
            set { this._invokeMode = value; }
        }

        // Check to see if InvokeMode property is set
        internal bool IsSetInvokeMode()
        {
            return this._invokeMode != null;
        }

    }
}