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
    /// Container for the parameters to the UpdateFunctionUrlConfig operation.
    /// Updates the configuration for a Lambda function URL.
    /// </summary>
    public partial class UpdateFunctionUrlConfigRequest : AmazonLambdaRequest
    {
        private FunctionUrlAuthType _authType;
        private Cors _cors;
        private string _functionName;
        private InvokeMode _invokeMode;
        private string _qualifier;

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
        [AWSProperty(Required=true, Min=1, Max=140)]
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
        /// The maximum response payload size is 200 MB.
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