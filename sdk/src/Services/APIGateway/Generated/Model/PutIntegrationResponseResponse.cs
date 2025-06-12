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
    /// Represents an integration response. The status code must map to an existing MethodResponse,
    /// and parameters and templates can be used to transform the back-end response.
    /// </summary>
    public partial class PutIntegrationResponseResponse : AmazonWebServiceResponse
    {
        private ContentHandlingStrategy _contentHandling;
        private Dictionary<string, string> _responseParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _responseTemplates = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _selectionPattern;
        private string _statusCode;

        /// <summary>
        /// Gets and sets the property ContentHandling. 
        /// <para>
        /// Specifies how to handle response payload content type conversions. Supported values
        /// are <c>CONVERT_TO_BINARY</c> and <c>CONVERT_TO_TEXT</c>, with the following behaviors:
        /// </para>
        ///  
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
        /// Gets and sets the property ResponseParameters. 
        /// <para>
        /// A key-value map specifying response parameters that are passed to the method response
        /// from the back end. The key is a method response header parameter name and the mapped
        /// value is an integration response header value, a static value enclosed within a pair
        /// of single quotes, or a JSON expression from the integration response body. The mapping
        /// key must match the pattern of <c>method.response.header.{name}</c>, where <c>name</c>
        /// is a valid and unique header name. The mapped non-static value must match the pattern
        /// of <c>integration.response.header.{name}</c> or <c>integration.response.body.{JSON-expression}</c>,
        /// where <c>name</c> is a valid and unique response header name and <c>JSON-expression</c>
        /// is a valid JSON expression without the <c>$</c> prefix.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ResponseParameters
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
        /// Gets and sets the property ResponseTemplates. 
        /// <para>
        /// Specifies the templates used to transform the integration response body. Response
        /// templates are represented as a key/value map, with a content-type as the key and a
        /// template as the value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ResponseTemplates
        {
            get { return this._responseTemplates; }
            set { this._responseTemplates = value; }
        }

        // Check to see if ResponseTemplates property is set
        internal bool IsSetResponseTemplates()
        {
            return this._responseTemplates != null && (this._responseTemplates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelectionPattern. 
        /// <para>
        /// Specifies the regular expression (regex) pattern used to choose an integration response
        /// based on the response from the back end. For example, if the success response returns
        /// nothing and the error response returns some string, you could use the <c>.+</c> regex
        /// to match error response. However, make sure that the error response does not contain
        /// any newline (<c>\n</c>) character in such cases. If the back end is an Lambda function,
        /// the Lambda function error header is matched. For all other HTTP and Amazon Web Services
        /// back ends, the HTTP status code is matched.
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
        /// MethodResponse.
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