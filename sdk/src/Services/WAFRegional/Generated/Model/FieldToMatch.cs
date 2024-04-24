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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
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
namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Specifies where in a web request to look for <c>TargetString</c>.
    /// </para>
    /// </summary>
    public partial class FieldToMatch
    {
        private string _data;
        private MatchFieldType _type;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// When the value of <c>Type</c> is <c>HEADER</c>, enter the name of the header that
        /// you want AWS WAF to search, for example, <c>User-Agent</c> or <c>Referer</c>. The
        /// name of the header is not case sensitive.
        /// </para>
        ///  
        /// <para>
        /// When the value of <c>Type</c> is <c>SINGLE_QUERY_ARG</c>, enter the name of the parameter
        /// that you want AWS WAF to search, for example, <c>UserName</c> or <c>SalesRegion</c>.
        /// The parameter name is not case sensitive.
        /// </para>
        ///  
        /// <para>
        /// If the value of <c>Type</c> is any other value, omit <c>Data</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        ///  <ul> <li> 
        /// <para>
        ///  <c>HEADER</c>: A specified request header, for example, the value of the <c>User-Agent</c>
        /// or <c>Referer</c> header. If you choose <c>HEADER</c> for the type, specify the name
        /// of the header in <c>Data</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>METHOD</c>: The HTTP method, which indicated the type of operation that the request
        /// is asking the origin to perform. Amazon CloudFront supports the following methods:
        /// <c>DELETE</c>, <c>GET</c>, <c>HEAD</c>, <c>OPTIONS</c>, <c>PATCH</c>, <c>POST</c>,
        /// and <c>PUT</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUERY_STRING</c>: A query string, which is the part of a URL that appears after
        /// a <c>?</c> character, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>URI</c>: The part of a web request that identifies a resource, for example, <c>/images/daily-ad.jpg</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BODY</c>: The part of a request that contains any additional data that you want
        /// to send to your web server as the HTTP request body, such as data from a form. The
        /// request body immediately follows the request headers. Note that only the first <c>8192</c>
        /// bytes of the request body are forwarded to AWS WAF for inspection. To allow or block
        /// requests based on the length of the body, you can create a size constraint set. For
        /// more information, see <a>CreateSizeConstraintSet</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SINGLE_QUERY_ARG</c>: The parameter in the query string that you will inspect,
        /// such as <i>UserName</i> or <i>SalesRegion</i>. The maximum length for <c>SINGLE_QUERY_ARG</c>
        /// is 30 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL_QUERY_ARGS</c>: Similar to <c>SINGLE_QUERY_ARG</c>, but rather than inspecting
        /// a single parameter, AWS WAF will inspect all parameters within the query for the value
        /// or regex pattern that you specify in <c>TargetString</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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