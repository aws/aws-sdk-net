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
    /// Container for the parameters to the PutMethodResponse operation.
    /// Adds a MethodResponse to an existing Method resource.
    /// </summary>
    public partial class PutMethodResponseRequest : AmazonAPIGatewayRequest
    {
        private string _httpMethod;
        private string _resourceId;
        private Dictionary<string, string> _responseModels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, bool> _responseParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;
        private string _restApiId;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// The HTTP verb of the Method resource.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The Resource identifier for the Method resource.
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
        /// Gets and sets the property ResponseModels. 
        /// <para>
        /// Specifies the Model resources used for the response's content type. Response models
        /// are represented as a key/value map, with a content type as the key and a Model name
        /// as the value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ResponseModels
        {
            get { return this._responseModels; }
            set { this._responseModels = value; }
        }

        // Check to see if ResponseModels property is set
        internal bool IsSetResponseModels()
        {
            return this._responseModels != null && (this._responseModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// A key-value map specifying required or optional response parameters that API Gateway
        /// can send back to the caller. A key defines a method response header name and the associated
        /// value is a Boolean flag indicating whether the method response parameter is required
        /// or not. The method response header names must match the pattern of <c>method.response.header.{name}</c>,
        /// where <c>name</c> is a valid and unique header name. The response parameter names
        /// defined here are available in the integration response to be mapped from an integration
        /// response header expressed in <c>integration.response.header.{name}</c>, a static value
        /// enclosed within a pair of single quotes (e.g., <c>'application/json'</c>), or a JSON
        /// expression from the back-end response payload in the form of <c>integration.response.body.{JSON-expression}</c>,
        /// where <c>JSON-expression</c> is a valid JSON expression without the <c>$</c> prefix.)
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, bool> ResponseParameters
        {
            get { return this._responseParameters; }
            set { this._responseParameters = value; }
        }

        // Check to see if ResponseParameters property is set
        internal bool IsSetResponseParameters()
        {
            return this._responseParameters != null && (this._responseParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The method response's status code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

    }
}