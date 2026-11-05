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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the GetFunctionUrlConfig operation.
    /// </summary>
    public partial class GetFunctionUrlConfigResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The type of authentication that your function URL uses. Set to <c>AWS_IAM</c> if you
        /// want to restrict access to authenticated users only. Set to <c>NONE</c> if you want
        /// to bypass IAM authentication to create a public endpoint. For more information, see
        /// <a href="https://docs.aws.amazon.com/lambda/latest/dg/urls-auth.html">Control access
        /// to Lambda function URLs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FunctionUrlAuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property Cors. 
        /// <para>
        /// The <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS">cross-origin
        /// resource sharing (CORS)</a> settings for your function URL.
        /// </para>
        /// </summary>
        public Cors Cors { get; set; }

        /// <summary>
        /// Checks to see if the Cors property is set.
        /// </summary>
        internal bool IsSetCors() => this.Cors != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the function URL was created, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of your function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// Checks to see if the FunctionArn property is set.
        /// </summary>
        internal bool IsSetFunctionArn() => this.FunctionArn != null;

        /// <summary>
        /// Gets and sets the property FunctionUrl. 
        /// <para>
        /// The HTTP URL endpoint for your function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 40, Max = 100)]
        public string FunctionUrl { get; set; }

        /// <summary>
        /// Checks to see if the FunctionUrl property is set.
        /// </summary>
        internal bool IsSetFunctionUrl() => this.FunctionUrl != null;

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
        public InvokeMode InvokeMode { get; set; }

        /// <summary>
        /// Checks to see if the InvokeMode property is set.
        /// </summary>
        internal bool IsSetInvokeMode() => this.InvokeMode != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the function URL configuration was last updated, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime != null;
    }
}
