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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the TestInvokeMethod operation.
    /// Simulate the execution of a <a>Method</a> in your <a>RestApi</a> with headers, parameters,
    /// and an incoming request body.
    /// </summary>
    public partial class TestInvokeMethodRequest : AmazonAPIGatewayRequest
    {
        private string _body;
        private string _clientCertificateId;
        private Dictionary<string, string> _headers = new Dictionary<string, string>();
        private string _httpMethod;
        private string _pathWithQueryString;
        private string _resourceId;
        private string _restApiId;
        private Dictionary<string, string> _stageVariables = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The simulated request body of an incoming invocation request.
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property ClientCertificateId. 
        /// <para>
        /// A <a>ClientCertificate</a> identifier to use in the test invocation. API Gateway will
        /// use the certificate when making the HTTPS request to the defined back-end endpoint.
        /// </para>
        /// </summary>
        public string ClientCertificateId
        {
            get { return this._clientCertificateId; }
            set { this._clientCertificateId = value; }
        }

        // Check to see if ClientCertificateId property is set
        internal bool IsSetClientCertificateId()
        {
            return this._clientCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// A key-value map of headers to simulate an incoming invocation request.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && this._headers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// [Required] Specifies a test invoke method request's HTTP method.
        /// </para>
        /// </summary>
        public string HttpMethod
        {
            get { return this._httpMethod; }
            set { this._httpMethod = value; }
        }

        // Check to see if HttpMethod property is set
        internal bool IsSetHttpMethod()
        {
            return this._httpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property PathWithQueryString. 
        /// <para>
        /// The URI path, including query string, of the simulated invocation request. Use this
        /// to specify path parameters and query string parameters.
        /// </para>
        /// </summary>
        public string PathWithQueryString
        {
            get { return this._pathWithQueryString; }
            set { this._pathWithQueryString = value; }
        }

        // Check to see if PathWithQueryString property is set
        internal bool IsSetPathWithQueryString()
        {
            return this._pathWithQueryString != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// [Required] Specifies a test invoke method request's resource ID.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// [Required] The string identifier of the associated <a>RestApi</a>.
        /// </para>
        /// </summary>
        public string RestApiId
        {
            get { return this._restApiId; }
            set { this._restApiId = value; }
        }

        // Check to see if RestApiId property is set
        internal bool IsSetRestApiId()
        {
            return this._restApiId != null;
        }

        /// <summary>
        /// Gets and sets the property StageVariables. 
        /// <para>
        /// A key-value map of stage variables to simulate an invocation on a deployed <a>Stage</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> StageVariables
        {
            get { return this._stageVariables; }
            set { this._stageVariables = value; }
        }

        // Check to see if StageVariables property is set
        internal bool IsSetStageVariables()
        {
            return this._stageVariables != null && this._stageVariables.Count > 0; 
        }

    }
}