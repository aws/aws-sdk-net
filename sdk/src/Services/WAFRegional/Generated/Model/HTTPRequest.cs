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
    /// The response from a <a>GetSampledRequests</a> request includes an <c>HTTPRequest</c>
    /// complex type that appears as <c>Request</c> in the response syntax. <c>HTTPRequest</c>
    /// contains information about one of the web requests that were returned by <c>GetSampledRequests</c>.
    /// 
    /// </para>
    /// </summary>
    public partial class HTTPRequest
    {
        private string _clientIP;
        private string _country;
        private List<HTTPHeader> _headers = AWSConfigs.InitializeCollections ? new List<HTTPHeader>() : null;
        private string _httpVersion;
        private string _method;
        private string _uri;

        /// <summary>
        /// Gets and sets the property ClientIP. 
        /// <para>
        /// The IP address that the request originated from. If the <c>WebACL</c> is associated
        /// with a CloudFront distribution, this is the value of one of the following fields in
        /// CloudFront access logs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>c-ip</c>, if the viewer did not use an HTTP proxy or a load balancer to send the
        /// request
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-forwarded-for</c>, if the viewer did use an HTTP proxy or a load balancer to
        /// send the request
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ClientIP
        {
            get { return this._clientIP; }
            set { this._clientIP = value; }
        }

        // Check to see if ClientIP property is set
        internal bool IsSetClientIP()
        {
            return this._clientIP != null;
        }

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The two-letter country code for the country that the request originated from. For
        /// a current list of country codes, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>.
        /// </para>
        /// </summary>
        public string Country
        {
            get { return this._country; }
            set { this._country = value; }
        }

        // Check to see if Country property is set
        internal bool IsSetCountry()
        {
            return this._country != null;
        }

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// A complex type that contains two values for each header in the sampled web request:
        /// the name of the header and the value of the header.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HTTPHeader> Headers
        {
            get { return this._headers; }
            set { this._headers = value; }
        }

        // Check to see if Headers property is set
        internal bool IsSetHeaders()
        {
            return this._headers != null && (this._headers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HTTPVersion. 
        /// <para>
        /// The HTTP version specified in the sampled web request, for example, <c>HTTP/1.1</c>.
        /// </para>
        /// </summary>
        public string HTTPVersion
        {
            get { return this._httpVersion; }
            set { this._httpVersion = value; }
        }

        // Check to see if HTTPVersion property is set
        internal bool IsSetHTTPVersion()
        {
            return this._httpVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The HTTP method specified in the sampled web request. CloudFront supports the following
        /// methods: <c>DELETE</c>, <c>GET</c>, <c>HEAD</c>, <c>OPTIONS</c>, <c>PATCH</c>, <c>POST</c>,
        /// and <c>PUT</c>. 
        /// </para>
        /// </summary>
        public string Method
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
        /// Gets and sets the property URI. 
        /// <para>
        /// The part of a web request that identifies the resource, for example, <c>/images/daily-ad.jpg</c>.
        /// </para>
        /// </summary>
        public string URI
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if URI property is set
        internal bool IsSetURI()
        {
            return this._uri != null;
        }

    }
}