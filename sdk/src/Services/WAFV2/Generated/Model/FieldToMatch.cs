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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The part of the web request that you want WAF to inspect. Include the single <code>FieldToMatch</code>
    /// type that you want to inspect, with additional specifications as needed, according
    /// to the type. You specify a single request component in <code>FieldToMatch</code> for
    /// each rule statement that requires it. To inspect more than one component of the web
    /// request, create a separate rule statement for each component.
    /// 
    ///  
    /// <para>
    /// Example JSON for a <code>QueryString</code> field to match: 
    /// </para>
    ///  
    /// <para>
    ///  <code> "FieldToMatch": { "QueryString": {} }</code> 
    /// </para>
    ///  
    /// <para>
    /// Example JSON for a <code>Method</code> field to match specification:
    /// </para>
    ///  
    /// <para>
    ///  <code> "FieldToMatch": { "Method": { "Name": "DELETE" } }</code> 
    /// </para>
    /// </summary>
    public partial class FieldToMatch
    {
        private AllQueryArguments _allQueryArguments;
        private Body _body;
        private Cookies _cookies;
        private Headers _headers;
        private JsonBody _jsonBody;
        private Method _method;
        private QueryString _queryString;
        private SingleHeader _singleHeader;
        private SingleQueryArgument _singleQueryArgument;
        private UriPath _uriPath;

        /// <summary>
        /// Gets and sets the property AllQueryArguments. 
        /// <para>
        /// Inspect all query arguments. 
        /// </para>
        /// </summary>
        public AllQueryArguments AllQueryArguments
        {
            get { return this._allQueryArguments; }
            set { this._allQueryArguments = value; }
        }

        // Check to see if AllQueryArguments property is set
        internal bool IsSetAllQueryArguments()
        {
            return this._allQueryArguments != null;
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// Inspect the request body as plain text. The request body immediately follows the request
        /// headers. This is the part of a request that contains any additional data that you
        /// want to send to your web server as the HTTP request body, such as data from a form.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Only the first 8 KB (8192 bytes) of the request body are forwarded to WAF for inspection
        /// by the underlying host service. For information about how to handle oversized request
        /// bodies, see the <code>Body</code> object configuration. 
        /// </para>
        /// </summary>
        public Body Body
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
        /// Gets and sets the property Cookies. 
        /// <para>
        /// Inspect the request cookies. You must configure scope and pattern matching filters
        /// in the <code>Cookies</code> object, to define the set of cookies and the parts of
        /// the cookies that WAF inspects. 
        /// </para>
        ///  
        /// <para>
        /// Only the first 8 KB (8192 bytes) of a request's cookies and only the first 200 cookies
        /// are forwarded to WAF for inspection by the underlying host service. You must configure
        /// how to handle any oversize cookie content in the <code>Cookies</code> object. WAF
        /// applies the pattern matching filters to the cookies that it receives from the underlying
        /// host service. 
        /// </para>
        /// </summary>
        public Cookies Cookies
        {
            get { return this._cookies; }
            set { this._cookies = value; }
        }

        // Check to see if Cookies property is set
        internal bool IsSetCookies()
        {
            return this._cookies != null;
        }

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// Inspect the request headers. You must configure scope and pattern matching filters
        /// in the <code>Headers</code> object, to define the set of headers to and the parts
        /// of the headers that WAF inspects. 
        /// </para>
        ///  
        /// <para>
        /// Only the first 8 KB (8192 bytes) of a request's headers and only the first 200 headers
        /// are forwarded to WAF for inspection by the underlying host service. You must configure
        /// how to handle any oversize header content in the <code>Headers</code> object. WAF
        /// applies the pattern matching filters to the headers that it receives from the underlying
        /// host service. 
        /// </para>
        /// </summary>
        public Headers Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null;
        }

        /// <summary>
        /// Gets and sets the property JsonBody. 
        /// <para>
        /// Inspect the request body as JSON. The request body immediately follows the request
        /// headers. This is the part of a request that contains any additional data that you
        /// want to send to your web server as the HTTP request body, such as data from a form.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Only the first 8 KB (8192 bytes) of the request body are forwarded to WAF for inspection
        /// by the underlying host service. For information about how to handle oversized request
        /// bodies, see the <code>JsonBody</code> object configuration. 
        /// </para>
        /// </summary>
        public JsonBody JsonBody
        {
            get { return this._jsonBody; }
            set { this._jsonBody = value; }
        }

        // Check to see if JsonBody property is set
        internal bool IsSetJsonBody()
        {
            return this._jsonBody != null;
        }

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// Inspect the HTTP method. The method indicates the type of operation that the request
        /// is asking the origin to perform. 
        /// </para>
        /// </summary>
        public Method Method
        {
            get { return this._method; }
            set { this._method = value; }
        }

        // Check to see if Method property is set
        internal bool IsSetMethod()
        {
            return this._method != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// Inspect the query string. This is the part of a URL that appears after a <code>?</code>
        /// character, if any.
        /// </para>
        /// </summary>
        public QueryString QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property SingleHeader. 
        /// <para>
        /// Inspect a single header. Provide the name of the header to inspect, for example, <code>User-Agent</code>
        /// or <code>Referer</code>. This setting isn't case sensitive.
        /// </para>
        ///  
        /// <para>
        /// Example JSON: <code>"SingleHeader": { "Name": "haystack" }</code> 
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can filter and inspect all headers with the <code>Headers</code>
        /// <code>FieldToMatch</code> setting. 
        /// </para>
        /// </summary>
        public SingleHeader SingleHeader
        {
            get { return this._singleHeader; }
            set { this._singleHeader = value; }
        }

        // Check to see if SingleHeader property is set
        internal bool IsSetSingleHeader()
        {
            return this._singleHeader != null;
        }

        /// <summary>
        /// Gets and sets the property SingleQueryArgument. 
        /// <para>
        /// Inspect a single query argument. Provide the name of the query argument to inspect,
        /// such as <i>UserName</i> or <i>SalesRegion</i>. The name can be up to 30 characters
        /// long and isn't case sensitive. 
        /// </para>
        ///  
        /// <para>
        /// Example JSON: <code>"SingleQueryArgument": { "Name": "myArgument" }</code> 
        /// </para>
        /// </summary>
        public SingleQueryArgument SingleQueryArgument
        {
            get { return this._singleQueryArgument; }
            set { this._singleQueryArgument = value; }
        }

        // Check to see if SingleQueryArgument property is set
        internal bool IsSetSingleQueryArgument()
        {
            return this._singleQueryArgument != null;
        }

        /// <summary>
        /// Gets and sets the property UriPath. 
        /// <para>
        /// Inspect the request URI path. This is the part of the web request that identifies
        /// a resource, for example, <code>/images/daily-ad.jpg</code>.
        /// </para>
        /// </summary>
        public UriPath UriPath
        {
            get { return this._uriPath; }
            set { this._uriPath = value; }
        }

        // Check to see if UriPath property is set
        internal bool IsSetUriPath()
        {
            return this._uriPath != null;
        }

    }
}