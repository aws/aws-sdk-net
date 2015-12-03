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
    /// Represents an integration response. The status code must map to an existing <a>MethodResponse</a>,
    /// and parameters and templates can be used to transform the backend response.
    /// </summary>
    public partial class UpdateIntegrationResponseResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _responseParameters = new Dictionary<string, string>();
        private Dictionary<string, string> _responseTemplates = new Dictionary<string, string>();
        private string _selectionPattern;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// Represents response parameters that can be read from the backend response. Response
        /// parameters are represented as a key/value map, with a destination as the key and a
        /// source as the value. A destination must match an existing response parameter in the
        /// <a>Method</a>. The source can be a header from the backend response, or a static value.
        /// Static values are specified using enclosing single quotes, and backend response headers
        /// can be read using the pattern <code>integration.response.header.{name}</code>.
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
        /// Specifies the templates used to transform the integration response body. Response
        /// templates are represented as a key/value map, with a content-type as the key and a
        /// template as the value.
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
        /// Gets and sets the property SelectionPattern. 
        /// <para>
        /// Specifies the regular expression (regex) pattern used to choose an integration response
        /// based on the response from the backend. If the backend is an AWS Lambda function,
        /// the AWS Lambda function error header is matched. For all other HTTP and AWS backends,
        /// the HTTP status code is matched.
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
        /// Specifies the status code that is used to map the integration response to an existing
        /// <a>MethodResponse</a>.
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