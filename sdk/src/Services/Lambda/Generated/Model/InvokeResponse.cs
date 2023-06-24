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
    /// This is the response object from the Invoke operation.
    /// </summary>
    public partial class InvokeResponse : AmazonWebServiceResponse
    {
        private string _executedVersion;
        private string _functionError;
        private string _logResult;
        private MemoryStream _payload;
        private int? _statusCode;

        /// <summary>
        /// Gets and sets the property ExecutedVersion. 
        /// <para>
        /// The version of the function that executed. When you invoke a function with an alias,
        /// this indicates which version the alias resolved to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ExecutedVersion
        {
            get { return this._executedVersion; }
            set { this._executedVersion = value; }
        }

        // Check to see if ExecutedVersion property is set
        internal bool IsSetExecutedVersion()
        {
            return this._executedVersion != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionError. 
        /// <para>
        /// If present, indicates that an error occurred during function execution. Details about
        /// the error are included in the response payload.
        /// </para>
        /// </summary>
        public string FunctionError
        {
            get { return this._functionError; }
            set { this._functionError = value; }
        }

        // Check to see if FunctionError property is set
        internal bool IsSetFunctionError()
        {
            return this._functionError != null;
        }

        /// <summary>
        /// Gets and sets the property LogResult. 
        /// <para>
        /// The last 4 KB of the execution log, which is base64-encoded.
        /// </para>
        /// </summary>
        public string LogResult
        {
            get { return this._logResult; }
            set { this._logResult = value; }
        }

        // Check to see if LogResult property is set
        internal bool IsSetLogResult()
        {
            return this._logResult != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The response from the function, or an error object.
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
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status code is in the 200 range for a successful request. For the <code>RequestResponse</code>
        /// invocation type, this status code is 200. For the <code>Event</code> invocation type,
        /// this status code is 202. For the <code>DryRun</code> invocation type, the status code
        /// is 204.
        /// </para>
        /// </summary>
        public int StatusCode
        {
            get { return this._statusCode.GetValueOrDefault(); }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

    }
}