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
    /// Represents a method response of a given HTTP status code returned to the client. The
    /// method response is passed from the back end through the associated integration response
    /// that can be transformed using a mapping template.
    /// </summary>
    public partial class GetMethodResponseResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _responseModels = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, bool> _responseParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, bool>() : null;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property ResponseModels. 
        /// <para>
        /// Specifies the Model resources used for the response's content-type. Response models
        /// are represented as a key/value map, with a content-type as the key and a Model name
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
        /// can send back to the caller. A key defines a method response header and the value
        /// specifies whether the associated method response header is required or not. The expression
        /// of the key must match the pattern <c>method.response.header.{name}</c>, where <c>name</c>
        /// is a valid and unique header name. API Gateway passes certain integration response
        /// data to the method response headers specified here according to the mapping you prescribe
        /// in the API's IntegrationResponse. The integration response data that can be mapped
        /// include an integration response header expressed in <c>integration.response.header.{name}</c>,
        /// a static value enclosed within a pair of single quotes (e.g., <c>'application/json'</c>),
        /// or a JSON expression from the back-end response payload in the form of <c>integration.response.body.{JSON-expression}</c>,
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
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The method response's status code.
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