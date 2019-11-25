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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// The part of a web request that you want AWS WAF to inspect. Include the <code>FieldToMatch</code>
    /// types that you want to inspect, with additional specifications as needed, according
    /// to the type. 
    /// </para>
    /// </summary>
    public partial class FieldToMatch
    {
        private AllQueryArguments _allQueryArguments;
        private Body _body;
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
        /// Inspect the request body, which immediately follows the request headers. This is the
        /// part of a request that contains any additional data that you want to send to your
        /// web server as the HTTP request body, such as data from a form. 
        /// </para>
        ///  
        /// <para>
        /// Note that only the first 8 KB (8192 bytes) of the request body are forwarded to AWS
        /// WAF for inspection. If you don't need to inspect more than 8 KB, you can guarantee
        /// that you don't allow additional bytes in by combining a statement that inspects the
        /// body of the web request, such as <a>ByteMatchStatement</a> or <a>RegexPatternSetReferenceStatement</a>,
        /// with a <a>SizeConstraintStatement</a> that enforces an 8 KB size limit on the body
        /// of the request. AWS WAF doesn't support inspecting the entire contents of web requests
        /// whose bodies exceed the 8 KB limit.
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
        /// Inspect the request URI path. This is the part of a web request that identifies a
        /// resource, for example, <code>/images/daily-ad.jpg</code>.
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