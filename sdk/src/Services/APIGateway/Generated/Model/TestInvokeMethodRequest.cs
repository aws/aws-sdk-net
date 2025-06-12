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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the TestInvokeMethod operation.
    /// Simulate the invocation of a Method in your RestApi with headers, parameters, and
    /// an incoming request body.
    /// </summary>
    public partial class TestInvokeMethodRequest : AmazonAPIGatewayRequest
    {
        private string _body;
        private string _clientCertificateId;
        private Dictionary<string, string> _headers = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _httpMethod;
        private Dictionary<string, List<string>> _multiValueHeaders = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _pathWithQueryString;
        private string _resourceId;
        private string _restApiId;
        private Dictionary<string, string> _stageVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// A ClientCertificate identifier to use in the test invocation. API Gateway will use
        /// the certificate when making the HTTPS request to the defined back-end endpoint.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && (this._headers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// Specifies a test invoke method request's HTTP method.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MultiValueHeaders. 
        /// <para>
        /// The headers as a map from string to list of values to simulate an incoming invocation
        /// request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> MultiValueHeaders
        {
            get { return this._multiValueHeaders; }
            set { this._multiValueHeaders = value; }
        }

        // Check to see if MultiValueHeaders property is set
        internal bool IsSetMultiValueHeaders()
        {
            return this._multiValueHeaders != null && (this._multiValueHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Specifies a test invoke method request's resource ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The string identifier of the associated RestApi.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A key-value map of stage variables to simulate an invocation on a deployed Stage.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> StageVariables
        {
            get { return this._stageVariables; }
            set { this._stageVariables = value; }
        }

        // Check to see if StageVariables property is set
        internal bool IsSetStageVariables()
        {
            return this._stageVariables != null && (this._stageVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}