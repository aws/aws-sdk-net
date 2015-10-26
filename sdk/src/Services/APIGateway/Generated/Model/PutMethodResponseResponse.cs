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
    /// Represents a method response. Amazon API Gateway sends back the status code to the
    /// caller as the HTTP status code. Parameters and models can be used to transform the
    /// response from the method's integration.
    /// </summary>
    public partial class PutMethodResponseResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _responseModels = new Dictionary<string, string>();
        private Dictionary<string, bool> _responseParameters = new Dictionary<string, bool>();
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property ResponseModels. 
        /// <para>
        /// Specifies the <a>Model</a> resources used for the response's content-type. Response
        /// models are represented as a key/value map, with a content-type as the key and a <a>Model</a>
        /// name as the value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> ResponseModels
        {
            get { return this._responseModels; }
            set { this._responseModels = value; }
        }

        // Check to see if ResponseModels property is set
        internal bool IsSetResponseModels()
        {
            return this._responseModels != null && this._responseModels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// Represents response parameters that can be sent back to the caller by Amazon API Gateway.
        /// Response parameters are represented as a key/value map, with a destination as the
        /// key and a boolean flag as the value, which is used to specify whether the parameter
        /// is required. A destination must match the pattern <code>method.response.header.{name}</code>,
        /// where <code>name</code> is a valid, unique header name. Destinations specified here
        /// are available to the integration for mapping from integration response parameters.
        /// </para>
        /// </summary>
        public Dictionary<string, bool> ResponseParameters
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