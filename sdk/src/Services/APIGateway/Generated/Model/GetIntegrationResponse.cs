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
    /// Represents a HTTP, AWS, or Mock integration.
    /// </summary>
    public partial class GetIntegrationResponse : AmazonWebServiceResponse
    {
        private List<string> _cacheKeyParameters = new List<string>();
        private string _cacheNamespace;
        private string _credentials;
        private string _httpMethod;
        private Dictionary<string, IntegrationResponse> _integrationResponses = new Dictionary<string, IntegrationResponse>();
        private Dictionary<string, string> _requestParameters = new Dictionary<string, string>();
        private Dictionary<string, string> _requestTemplates = new Dictionary<string, string>();
        private IntegrationType _type;
        private string _uri;

        /// <summary>
        /// Gets and sets the property CacheKeyParameters. 
        /// <para>
        /// Specifies the integration's cache key parameters.
        /// </para>
        /// </summary>
        public List<string> CacheKeyParameters
        {
            get { return this._cacheKeyParameters; }
            set { this._cacheKeyParameters = value; }
        }

        // Check to see if CacheKeyParameters property is set
        internal bool IsSetCacheKeyParameters()
        {
            return this._cacheKeyParameters != null && this._cacheKeyParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CacheNamespace. 
        /// <para>
        /// Specifies the integration's cache namespace.
        /// </para>
        /// </summary>
        public string CacheNamespace
        {
            get { return this._cacheNamespace; }
            set { this._cacheNamespace = value; }
        }

        // Check to see if CacheNamespace property is set
        internal bool IsSetCacheNamespace()
        {
            return this._cacheNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// Specifies the credentials required for the integration, if any. For AWS integrations,
        /// three options are available. To specify an IAM Role for Amazon API Gateway to assume,
        /// use the role's Amazon Resource Name (ARN). To require that the caller's identity be
        /// passed through from the request, specify the string <code>arn:aws:iam::\*:user/\*</code>.
        /// To use resource-based permissions on supported AWS services, specify null.
        /// </para>
        /// </summary>
        public string Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property HttpMethod. 
        /// <para>
        /// Specifies the integration's HTTP method type.
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
        /// Gets and sets the property IntegrationResponses. 
        /// <para>
        /// Specifies the integration's responses.
        /// </para>
        /// </summary>
        public Dictionary<string, IntegrationResponse> IntegrationResponses
        {
            get { return this._integrationResponses; }
            set { this._integrationResponses = value; }
        }

        // Check to see if IntegrationResponses property is set
        internal bool IsSetIntegrationResponses()
        {
            return this._integrationResponses != null && this._integrationResponses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequestParameters. 
        /// <para>
        /// Represents requests parameters that are sent with the backend request. Request parameters
        /// are represented as a key/value map, with a destination as the key and a source as
        /// the value. A source must match an existing method request parameter, or a static value.
        /// Static values must be enclosed with single quotes, and be pre-encoded based on their
        /// destination in the request. The destination must match the pattern <code>integration.request.{location}.{name}</code>,
        /// where <code>location</code> is either querystring, path, or header. <code>name</code>
        /// must be a valid, unique parameter name.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RequestParameters
        {
            get { return this._requestParameters; }
            set { this._requestParameters = value; }
        }

        // Check to see if RequestParameters property is set
        internal bool IsSetRequestParameters()
        {
            return this._requestParameters != null && this._requestParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequestTemplates. 
        /// <para>
        /// Specifies the integration's request templates.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RequestTemplates
        {
            get { return this._requestTemplates; }
            set { this._requestTemplates = value; }
        }

        // Check to see if RequestTemplates property is set
        internal bool IsSetRequestTemplates()
        {
            return this._requestTemplates != null && this._requestTemplates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the integration's type. The valid value is <code>HTTP</code>, <code>AWS</code>,
        /// or <code>MOCK</code>.
        /// </para>
        /// </summary>
        public IntegrationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// Specifies the integration's Uniform Resource Identifier (URI). For HTTP integrations,
        /// the URI must be a fully formed, encoded HTTP(S) URL according to the <a href="https://www.ietf.org/rfc/rfc3986.txt"
        /// target="_blank">RFC-3986 specification</a>. For AWS integrations, the URI should be
        /// of the form <code>arn:aws:apigateway:{region}:{subdomain.service|service}:{path|action}/{service_api}</code>.
        /// <code>Region</code>, <code>subdomain</code> and <code>service</code> are used to determine
        /// the right endpoint. For AWS services that use the <code>Action=</code> query string
        /// parameter, <code>service_api</code> should be a valid action for the desired service.
        /// For RESTful AWS service APIs, <code>path</code> is used to indicate that the remaining
        /// substring in the URI should be treated as the path to the resource, including the
        /// initial <code>/</code>.
        /// </para>
        /// </summary>
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}