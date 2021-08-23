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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the PutGatewayResponse operation.
    /// Creates a customization of a <a>GatewayResponse</a> of a specified response type and
    /// status code on the given <a>RestApi</a>.
    /// </summary>
    public partial class PutGatewayResponseRequest : AmazonAPIGatewayRequest
    {
        private Dictionary<string, string> _responseParameters = new Dictionary<string, string>();
        private Dictionary<string, string> _responseTemplates = new Dictionary<string, string>();
        private GatewayResponseType _responseType;
        private string _restApiId;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// 
        /// <para>
        /// Response parameters (paths, query strings and headers) of the <a>GatewayResponse</a>
        /// as a string-to-string map of key-value pairs.
        /// </para>
        /// 
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
        /// 
        /// <para>
        /// Response templates of the <a>GatewayResponse</a> as a string-to-string map of key-value
        /// pairs.
        /// </para>
        /// 
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
        /// Gets and sets the property ResponseType. 
        /// <para>
        /// [Required] 
        /// <para>
        /// The response type of the associated <a>GatewayResponse</a>.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GatewayResponseType ResponseType
        {
            get { return this._responseType; }
            set { this._responseType = value; }
        }

        // Check to see if ResponseType property is set
        internal bool IsSetResponseType()
        {
            return this._responseType != null;
        }

        /// <summary>
        /// Gets and sets the property RestApiId. 
        /// <para>
        /// [Required] The string identifier of the associated <a>RestApi</a>.
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
        /// Gets and sets the property StatusCode. The HTTP status code of the <a>GatewayResponse</a>.
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