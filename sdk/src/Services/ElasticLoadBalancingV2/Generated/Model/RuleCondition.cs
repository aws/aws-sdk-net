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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a condition for a rule.
    /// 
    ///  
    /// <para>
    /// Each rule can optionally include up to one of each of the following conditions: <code>http-request-method</code>,
    /// <code>host-header</code>, <code>path-pattern</code>, and <code>source-ip</code>. Each
    /// rule can also optionally include one or more of each of the following conditions:
    /// <code>http-header</code> and <code>query-string</code>.
    /// </para>
    /// </summary>
    public partial class RuleCondition
    {
        private string _field;
        private HostHeaderConditionConfig _hostHeaderConfig;
        private HttpHeaderConditionConfig _httpHeaderConfig;
        private HttpRequestMethodConditionConfig _httpRequestMethodConfig;
        private PathPatternConditionConfig _pathPatternConfig;
        private QueryStringConditionConfig _queryStringConfig;
        private SourceIpConditionConfig _sourceIpConfig;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The field in the HTTP request. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>http-header</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>http-request-method</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>host-header</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>path-pattern</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>query-string</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>source-ip</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property HostHeaderConfig. 
        /// <para>
        /// Information for a host header condition. Specify only when <code>Field</code> is <code>host-header</code>.
        /// </para>
        /// </summary>
        public HostHeaderConditionConfig HostHeaderConfig
        {
            get { return this._hostHeaderConfig; }
            set { this._hostHeaderConfig = value; }
        }

        // Check to see if HostHeaderConfig property is set
        internal bool IsSetHostHeaderConfig()
        {
            return this._hostHeaderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HttpHeaderConfig. 
        /// <para>
        /// Information for an HTTP header condition. Specify only when <code>Field</code> is
        /// <code>http-header</code>.
        /// </para>
        /// </summary>
        public HttpHeaderConditionConfig HttpHeaderConfig
        {
            get { return this._httpHeaderConfig; }
            set { this._httpHeaderConfig = value; }
        }

        // Check to see if HttpHeaderConfig property is set
        internal bool IsSetHttpHeaderConfig()
        {
            return this._httpHeaderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property HttpRequestMethodConfig. 
        /// <para>
        /// Information for an HTTP method condition. Specify only when <code>Field</code> is
        /// <code>http-request-method</code>.
        /// </para>
        /// </summary>
        public HttpRequestMethodConditionConfig HttpRequestMethodConfig
        {
            get { return this._httpRequestMethodConfig; }
            set { this._httpRequestMethodConfig = value; }
        }

        // Check to see if HttpRequestMethodConfig property is set
        internal bool IsSetHttpRequestMethodConfig()
        {
            return this._httpRequestMethodConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PathPatternConfig. 
        /// <para>
        /// Information for a path pattern condition. Specify only when <code>Field</code> is
        /// <code>path-pattern</code>.
        /// </para>
        /// </summary>
        public PathPatternConditionConfig PathPatternConfig
        {
            get { return this._pathPatternConfig; }
            set { this._pathPatternConfig = value; }
        }

        // Check to see if PathPatternConfig property is set
        internal bool IsSetPathPatternConfig()
        {
            return this._pathPatternConfig != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStringConfig. 
        /// <para>
        /// Information for a query string condition. Specify only when <code>Field</code> is
        /// <code>query-string</code>.
        /// </para>
        /// </summary>
        public QueryStringConditionConfig QueryStringConfig
        {
            get { return this._queryStringConfig; }
            set { this._queryStringConfig = value; }
        }

        // Check to see if QueryStringConfig property is set
        internal bool IsSetQueryStringConfig()
        {
            return this._queryStringConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIpConfig. 
        /// <para>
        /// Information for a source IP condition. Specify only when <code>Field</code> is <code>source-ip</code>.
        /// </para>
        /// </summary>
        public SourceIpConditionConfig SourceIpConfig
        {
            get { return this._sourceIpConfig; }
            set { this._sourceIpConfig = value; }
        }

        // Check to see if SourceIpConfig property is set
        internal bool IsSetSourceIpConfig()
        {
            return this._sourceIpConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The condition value. Specify only when <code>Field</code> is <code>host-header</code>
        /// or <code>path-pattern</code>. Alternatively, to specify multiple host names or multiple
        /// path patterns, use <code>HostHeaderConfig</code> or <code>PathPatternConfig</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>Field</code> is <code>host-header</code> and you are not using <code>HostHeaderConfig</code>,
        /// you can specify a single host name (for example, my.example.com) in <code>Values</code>.
        /// A host name is case insensitive, can be up to 128 characters in length, and can contain
        /// any of the following characters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A-Z, a-z, 0-9
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// - .
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// * (matches 0 or more characters)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ? (matches exactly 1 character)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If <code>Field</code> is <code>path-pattern</code> and you are not using <code>PathPatternConfig</code>,
        /// you can specify a single path pattern (for example, /img/*) in <code>Values</code>.
        /// A path pattern is case-sensitive, can be up to 128 characters in length, and can contain
        /// any of the following characters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A-Z, a-z, 0-9
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// _ - . $ / ~ " ' @ : +
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// &amp; (using &amp;amp;)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// * (matches 0 or more characters)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ? (matches exactly 1 character)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}