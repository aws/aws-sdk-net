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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Specifies where in a web request to look for <code>TargetString</code>.
    /// </summary>
    public partial class FieldToMatch
    {
        private string _data;
        private MatchFieldType _type;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// When the value of <code>Type</code> is <code>HEADER</code>, enter the name of the
        /// header that you want AWS WAF to search, for example, <code>User-Agent</code> or <code>Referer</code>.
        /// If the value of <code>Type</code> is any other value, omit <code>Data</code>.
        /// </para>
        ///  
        /// <para>
        /// The name of the header is not case sensitive.
        /// </para>
        /// </summary>
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The part of the web request that you want AWS WAF to search for a specified string.
        /// Parts of a request that you can search include the following:
        /// </para>
        ///  <ul> <li><code>HEADER</code>: A specified request header, for example, the value
        /// of the <code>User-Agent</code> or <code>Referer</code> header. If you choose <code>HEADER</code>
        /// for the type, specify the name of the header in <code>Data</code>.</li> <li><code>METHOD</code>:
        /// The HTTP method, which indicated the type of operation that the request is asking
        /// the origin to perform. Amazon CloudFront supports the following methods: <code>DELETE</code>,
        /// <code>GET</code>, <code>HEAD</code>, <code>OPTIONS</code>, <code>PATCH</code>, <code>POST</code>,
        /// and <code>PUT</code>.</li> <li><code>QUERY_STRING</code>: A query string, which is
        /// the part of a URL that appears after a <code>?</code> character, if any.</li> <li><code>URI</code>:
        /// The part of a web request that identifies a resource, for example, <code>/images/daily-ad.jpg</code>.</li>
        /// <li><code>BODY</code>: The part of a request that contains any additional data that
        /// you want to send to your web server as the HTTP request body, such as data from a
        /// form. The request body immediately follows the request headers. Note that only the
        /// first <code>8192</code> bytes of the request body are forwarded to AWS WAF for inspection.
        /// To allow or block requests based on the length of the body, you can create a size
        /// constraint set. For more information, see <a>CreateSizeConstraintSet</a>. </li> </ul>
        /// </summary>
        public MatchFieldType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}