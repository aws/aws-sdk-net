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
    /// Container for the parameters to the PutIntegrationResponse operation.
    /// Represents a put integration.
    /// </summary>
    public partial class PutIntegrationResponseRequest : AmazonAPIGatewayRequest
    {
        private ContentHandlingStrategy _contentHandling;
        private string _httpMethod;
        private string _resourceId;
        private Dictionary<string, string> _responseParameters = new Dictionary<string, string>();
        private Dictionary<string, string> _responseTemplates = new Dictionary<string, string>();
        private string _restApiId;
        private string _selectionPattern;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property ContentHandling. 
        /// <para>
        /// Specifies how to handle response payload content type conversions. Supported values
        /// are <code>CONVERT_TO_BINARY</code> and <code>CONVERT_TO_TEXT</code>, with the following
        /// behaviors:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <code>CONVERT_TO_BINARY</code>: Converts a response payload from a Base64-encoded
        /// string to the corresponding binary blob.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>CONVERT_TO_TEXT</code>: Converts a response payload from a binary blob to a
        /// Base64-encoded string.
        /// </para>
        /// </li> </ul> 
        /// <para>
        /// If this property is not defined, the response payload will be passed through from
        /// the integration response to the method response without modification.
        /// </para>
        /// </summary>
        public ContentHandlingStrategy ContentHandling
        {
            get { return this._contentHandling; }
            set { this._contentHandling = value; }
        }

        // Check to see if ContentHandling property is set
        internal bool IsSetContentHandling()
        {
            return this._contentHandling != null;
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// [Required] Specifies a put integration response request's HTTP method.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// [Required] Specifies a put integration response request's resource identifier.
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
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// A key-value map specifying response parameters that are passed to the method response
        /// from the back end. The key is a method response header parameter name and the mapped
        /// value is an integration response header value, a static value enclosed within a pair
        /// of single quotes, or a JSON expression from the integration response body. The mapping
        /// key must match the pattern of <code>method.response.header.{name}</code>, where <code>name</code>
        /// is a valid and unique header name. The mapped non-static value must match the pattern
        /// of <code>integration.response.header.{name}</code> or <code>integration.response.body.{JSON-expression}</code>,
        /// where <code>name</code> must be a valid and unique response header name and <code>JSON-expression</code>
        /// a valid JSON expression without the <code>$</code> prefix.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ResponseParameters
        {
            get { return this._responseParameters; }
            set { this._responseParameters = value; }
        }

        // Check to see if ResponseParameters property is set
        internal bool IsSetResponseParameters()
        {
            return this._responseParameters != null && this._responseParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResponseTemplates. 
        /// <para>
        /// Specifies a put integration response's templates.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ResponseTemplates
        {
            get { return this._responseTemplates; }
            set { this._responseTemplates = value; }
        }

        // Check to see if ResponseTemplates property is set
        internal bool IsSetResponseTemplates()
        {
            return this._responseTemplates != null && this._responseTemplates.Count > 0; 
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
        /// Gets and sets the property SelectionPattern. 
        /// <para>
        /// Specifies the selection pattern of a put integration response.
        /// </para>
        /// </summary>
        public string SelectionPattern
        {
            get { return this._selectionPattern; }
            set { this._selectionPattern = value; }
        }

        // Check to see if SelectionPattern property is set
        internal bool IsSetSelectionPattern()
        {
            return this._selectionPattern != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// [Required] Specifies the status code that is used to map the integration response
        /// to an existing <a>MethodResponse</a>.
        /// </para>
        /// </summary>
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