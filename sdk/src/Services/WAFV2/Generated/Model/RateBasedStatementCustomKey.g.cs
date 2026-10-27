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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Specifies a single custom aggregate key for a rate-base rule. 
    /// 
    ///  <note> 
    /// <para>
    /// Web requests that are missing any of the components specified in the aggregation keys
    /// are omitted from the rate-based rule evaluation and handling. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RateBasedStatementCustomKey
    {
        /// <summary>
        /// Gets and sets the property ASN. 
        /// <para>
        /// Use an Autonomous System Number (ASN) derived from the request's originating or forwarded
        /// IP address as an aggregate key. Each distinct ASN contributes to the aggregation instance.
        /// 
        /// </para>
        /// </summary>
        public RateLimitAsn ASN { get; set; }

        /// <summary>
        /// Checks to see if the ASN property is set.
        /// </summary>
        internal bool IsSetASN() => this.ASN != null;

        /// <summary>
        /// Gets and sets the property Cookie. 
        /// <para>
        /// Use the value of a cookie in the request as an aggregate key. Each distinct value
        /// in the cookie contributes to the aggregation instance. If you use a single cookie
        /// as your custom key, then each value fully defines an aggregation instance. 
        /// </para>
        /// </summary>
        public RateLimitCookie Cookie { get; set; }

        /// <summary>
        /// Checks to see if the Cookie property is set.
        /// </summary>
        internal bool IsSetCookie() => this.Cookie != null;

        /// <summary>
        /// Gets and sets the property ForwardedIP. 
        /// <para>
        /// Use the first IP address in an HTTP header as an aggregate key. Each distinct forwarded
        /// IP address contributes to the aggregation instance.
        /// </para>
        ///  
        /// <para>
        /// When you specify an IP or forwarded IP in the custom key settings, you must also specify
        /// at least one other key to use. You can aggregate on only the forwarded IP address
        /// by specifying <c>FORWARDED_IP</c> in your rate-based statement's <c>AggregateKeyType</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// With this option, you must specify the header to use in the rate-based rule's <c>ForwardedIPConfig</c>
        /// property. 
        /// </para>
        /// </summary>
        public RateLimitForwardedIP ForwardedIP { get; set; }

        /// <summary>
        /// Checks to see if the ForwardedIP property is set.
        /// </summary>
        internal bool IsSetForwardedIP() => this.ForwardedIP != null;

        /// <summary>
        /// Gets and sets the property HTTPMethod. 
        /// <para>
        /// Use the request's HTTP method as an aggregate key. Each distinct HTTP method contributes
        /// to the aggregation instance. If you use just the HTTP method as your custom key, then
        /// each method fully defines an aggregation instance. 
        /// </para>
        /// </summary>
        public RateLimitHTTPMethod HTTPMethod { get; set; }

        /// <summary>
        /// Checks to see if the HTTPMethod property is set.
        /// </summary>
        internal bool IsSetHTTPMethod() => this.HTTPMethod != null;

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// Use the value of a header in the request as an aggregate key. Each distinct value
        /// in the header contributes to the aggregation instance. If you use a single header
        /// as your custom key, then each value fully defines an aggregation instance. 
        /// </para>
        /// </summary>
        public RateLimitHeader Header { get; set; }

        /// <summary>
        /// Checks to see if the Header property is set.
        /// </summary>
        internal bool IsSetHeader() => this.Header != null;

        /// <summary>
        /// Gets and sets the property IP. 
        /// <para>
        /// Use the request's originating IP address as an aggregate key. Each distinct IP address
        /// contributes to the aggregation instance.
        /// </para>
        ///  
        /// <para>
        /// When you specify an IP or forwarded IP in the custom key settings, you must also specify
        /// at least one other key to use. You can aggregate on only the IP address by specifying
        /// <c>IP</c> in your rate-based statement's <c>AggregateKeyType</c>. 
        /// </para>
        /// </summary>
        public RateLimitIP IP { get; set; }

        /// <summary>
        /// Checks to see if the IP property is set.
        /// </summary>
        internal bool IsSetIP() => this.IP != null;

        /// <summary>
        /// Gets and sets the property JA3Fingerprint. 
        /// <para>
        ///  Use the request's JA3 fingerprint as an aggregate key. If you use a single JA3 fingerprint
        /// as your custom key, then each value fully defines an aggregation instance. 
        /// </para>
        /// </summary>
        public RateLimitJA3Fingerprint JA3Fingerprint { get; set; }

        /// <summary>
        /// Checks to see if the JA3Fingerprint property is set.
        /// </summary>
        internal bool IsSetJA3Fingerprint() => this.JA3Fingerprint != null;

        /// <summary>
        /// Gets and sets the property JA4Fingerprint. 
        /// <para>
        /// Use the request's JA4 fingerprint as an aggregate key. If you use a single JA4 fingerprint
        /// as your custom key, then each value fully defines an aggregation instance. 
        /// </para>
        /// </summary>
        public RateLimitJA4Fingerprint JA4Fingerprint { get; set; }

        /// <summary>
        /// Checks to see if the JA4Fingerprint property is set.
        /// </summary>
        internal bool IsSetJA4Fingerprint() => this.JA4Fingerprint != null;

        /// <summary>
        /// Gets and sets the property LabelNamespace. 
        /// <para>
        /// Use the specified label namespace as an aggregate key. Each distinct fully qualified
        /// label name that has the specified label namespace contributes to the aggregation instance.
        /// If you use just one label namespace as your custom key, then each label name fully
        /// defines an aggregation instance. 
        /// </para>
        ///  
        /// <para>
        /// This uses only labels that have been added to the request by rules that are evaluated
        /// before this rate-based rule in the web ACL. 
        /// </para>
        ///  
        /// <para>
        /// For information about label namespaces and names, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-label-requirements.html">Label
        /// syntax and naming requirements</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        /// </summary>
        public RateLimitLabelNamespace LabelNamespace { get; set; }

        /// <summary>
        /// Checks to see if the LabelNamespace property is set.
        /// </summary>
        internal bool IsSetLabelNamespace() => this.LabelNamespace != null;

        /// <summary>
        /// Gets and sets the property QueryArgument. 
        /// <para>
        /// Use the specified query argument as an aggregate key. Each distinct value for the
        /// named query argument contributes to the aggregation instance. If you use a single
        /// query argument as your custom key, then each value fully defines an aggregation instance.
        /// 
        /// </para>
        /// </summary>
        public RateLimitQueryArgument QueryArgument { get; set; }

        /// <summary>
        /// Checks to see if the QueryArgument property is set.
        /// </summary>
        internal bool IsSetQueryArgument() => this.QueryArgument != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// Use the request's query string as an aggregate key. Each distinct string contributes
        /// to the aggregation instance. If you use just the query string as your custom key,
        /// then each string fully defines an aggregation instance. 
        /// </para>
        /// </summary>
        public RateLimitQueryString QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property UriPath. 
        /// <para>
        /// Use the request's URI path as an aggregate key. Each distinct URI path contributes
        /// to the aggregation instance. If you use just the URI path as your custom key, then
        /// each URI path fully defines an aggregation instance. 
        /// </para>
        /// </summary>
        public RateLimitUriPath UriPath { get; set; }

        /// <summary>
        /// Checks to see if the UriPath property is set.
        /// </summary>
        internal bool IsSetUriPath() => this.UriPath != null;
    }
}
