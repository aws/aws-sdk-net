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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a condition for a rule.
    /// 
    ///  
    /// <para>
    /// Each rule can optionally include up to one of each of the following conditions: <c>http-request-method</c>,
    /// <c>host-header</c>, <c>path-pattern</c>, and <c>source-ip</c>. Each rule can also
    /// optionally include one or more of each of the following conditions: <c>http-header</c>
    /// and <c>query-string</c>. Note that the value for a condition can't be empty.
    /// </para>
    ///  
    /// <para>
    /// For Network Load Balancer listener rules, the only supported condition is <c>source-ip</c>.
    /// Use <c>SourceIpConfig</c> with <c>IpAddressType</c> to match on the IP address type
    /// of the source traffic (<c>ipv4</c> or <c>ipv6</c>).
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-limits.html">Quotas
    /// for your Application Load Balancers</a>.
    /// </para>
    /// </summary>
    public partial class RuleCondition
    {
        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The name of the field. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>http-header</c> – [ALB] Matches on an HTTP header field.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>http-request-method</c> – [ALB] Matches on the HTTP request method.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>host-header</c> – [ALB] Matches on the host header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>path-pattern</c> – [ALB] Matches on the URL path of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>query-string</c> – [ALB] Matches on a query string parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>source-ip</c> – [ALB, NLB] Matches on the source IP address. For ALB, use <c>SourceIpConfig</c>
        /// with <c>Values</c> to specify CIDR ranges. For NLB, use <c>SourceIpConfig</c> with
        /// <c>IpAddressType</c> to match the IP address type (<c>ipv4</c> or <c>ipv6</c>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Field { get; set; }

        /// <summary>
        /// Checks to see if the Field property is set.
        /// </summary>
        internal bool IsSetField() => this.Field != null;

        /// <summary>
        /// Gets and sets the property HostHeaderConfig. 
        /// <para>
        /// Information for a host header condition. Specify only when <c>Field</c> is <c>host-header</c>.
        /// </para>
        /// </summary>
        public HostHeaderConditionConfig HostHeaderConfig { get; set; }

        /// <summary>
        /// Checks to see if the HostHeaderConfig property is set.
        /// </summary>
        internal bool IsSetHostHeaderConfig() => this.HostHeaderConfig != null;

        /// <summary>
        /// Gets and sets the property HttpHeaderConfig. 
        /// <para>
        /// Information for an HTTP header condition. Specify only when <c>Field</c> is <c>http-header</c>.
        /// </para>
        /// </summary>
        public HttpHeaderConditionConfig HttpHeaderConfig { get; set; }

        /// <summary>
        /// Checks to see if the HttpHeaderConfig property is set.
        /// </summary>
        internal bool IsSetHttpHeaderConfig() => this.HttpHeaderConfig != null;

        /// <summary>
        /// Gets and sets the property HttpRequestMethodConfig. 
        /// <para>
        /// Information for an HTTP method condition. Specify only when <c>Field</c> is <c>http-request-method</c>.
        /// </para>
        /// </summary>
        public HttpRequestMethodConditionConfig HttpRequestMethodConfig { get; set; }

        /// <summary>
        /// Checks to see if the HttpRequestMethodConfig property is set.
        /// </summary>
        internal bool IsSetHttpRequestMethodConfig() => this.HttpRequestMethodConfig != null;

        /// <summary>
        /// Gets and sets the property PathPatternConfig. 
        /// <para>
        /// Information for a path pattern condition. Specify only when <c>Field</c> is <c>path-pattern</c>.
        /// </para>
        /// </summary>
        public PathPatternConditionConfig PathPatternConfig { get; set; }

        /// <summary>
        /// Checks to see if the PathPatternConfig property is set.
        /// </summary>
        internal bool IsSetPathPatternConfig() => this.PathPatternConfig != null;

        /// <summary>
        /// Gets and sets the property QueryStringConfig. 
        /// <para>
        /// Information for a query string condition. Specify only when <c>Field</c> is <c>query-string</c>.
        /// </para>
        /// </summary>
        public QueryStringConditionConfig QueryStringConfig { get; set; }

        /// <summary>
        /// Checks to see if the QueryStringConfig property is set.
        /// </summary>
        internal bool IsSetQueryStringConfig() => this.QueryStringConfig != null;

        /// <summary>
        /// Gets and sets the property RegexValues. 
        /// <para>
        /// The regular expressions to match against the condition field. The maximum length of
        /// each string is 128 characters. Specify only when <c>Field</c> is <c>http-header</c>,
        /// <c>host-header</c>, or <c>path-pattern</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RegexValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RegexValues property is set.
        /// </summary>
        internal bool IsSetRegexValues() => this.RegexValues != null && (this.RegexValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceIpConfig. 
        /// <para>
        /// Information for a source IP condition. Specify only when <c>Field</c> is <c>source-ip</c>.
        /// </para>
        /// </summary>
        public SourceIpConditionConfig SourceIpConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceIpConfig property is set.
        /// </summary>
        internal bool IsSetSourceIpConfig() => this.SourceIpConfig != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The condition value. Specify only when <c>Field</c> is <c>host-header</c> or <c>path-pattern</c>.
        /// Alternatively, to specify multiple host names or multiple path patterns, use <c>HostHeaderConfig</c>
        /// or <c>PathPatternConfig</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>Field</c> is <c>host-header</c> and you are not using <c>HostHeaderConfig</c>,
        /// you can specify a single host name (for example, my.example.com) in <c>Values</c>.
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
        /// If <c>Field</c> is <c>path-pattern</c> and you are not using <c>PathPatternConfig</c>,
        /// you can specify a single path pattern (for example, /img/*) in <c>Values</c>. A path
        /// pattern is case-sensitive, can be up to 128 characters in length, and can contain
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
        /// &amp; (using &amp;)
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
