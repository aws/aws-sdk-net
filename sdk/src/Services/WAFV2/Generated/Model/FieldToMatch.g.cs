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
    /// Specifies a web request component to be used in a rule match statement or in a logging
    /// configuration. 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// In a rule statement, this is the part of the web request that you want WAF to inspect.
    /// Include the single <c>FieldToMatch</c> type that you want to inspect, with additional
    /// specifications as needed, according to the type. You specify a single request component
    /// in <c>FieldToMatch</c> for each rule statement that requires it. To inspect more than
    /// one component of the web request, create a separate rule statement for each component.
    /// </para>
    ///  
    /// <para>
    /// Example JSON for a <c>QueryString</c> field to match: 
    /// </para>
    ///  
    /// <para>
    ///  <c> "FieldToMatch": { "QueryString": {} }</c> 
    /// </para>
    ///  
    /// <para>
    /// Example JSON for a <c>Method</c> field to match specification:
    /// </para>
    ///  
    /// <para>
    ///  <c> "FieldToMatch": { "Method": { "Name": "DELETE" } }</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In a logging configuration, this is used in the <c>RedactedFields</c> property to
    /// specify a field to redact from the logging records. For this use case, note the following:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Even though all <c>FieldToMatch</c> settings are available, the only valid settings
    /// for field redaction are <c>UriPath</c>, <c>QueryString</c>, <c>SingleHeader</c>, and
    /// <c>Method</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In this documentation, the descriptions of the individual fields talk about specifying
    /// the web request component to inspect, but for field redaction, you are specifying
    /// the component type to redact from the logs. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you have request sampling enabled, the redacted fields configuration for logging
    /// has no impact on sampling. You can only exclude fields from request sampling by disabling
    /// sampling in the web ACL visibility configuration or by configuring data protection
    /// for the web ACL.
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class FieldToMatch
    {
        /// <summary>
        /// Gets and sets the property AllQueryArguments. 
        /// <para>
        /// Inspect all query arguments. 
        /// </para>
        /// </summary>
        public AllQueryArguments AllQueryArguments { get; set; }

        /// <summary>
        /// Checks to see if the AllQueryArguments property is set.
        /// </summary>
        internal bool IsSetAllQueryArguments() => this.AllQueryArguments != null;

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
        /// WAF does not support inspecting the entire contents of the web request body if the
        /// body exceeds the limit for the resource type. When a web request body is larger than
        /// the limit, the underlying host service only forwards the contents that are within
        /// the limit to WAF for inspection. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Application Load Balancer and AppSync, the limit is fixed at 8 KB (8,192 bytes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For CloudFront, API Gateway, Amazon Cognito, App Runner, and Verified Access, the
        /// default limit is 16 KB (16,384 bytes), and you can increase the limit for each resource
        /// type in the web ACL <c>AssociationConfig</c>, for additional processing fees. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amplify, use the CloudFront limit.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about how to handle oversized request bodies, see the <c>Body</c>
        /// object configuration. 
        /// </para>
        /// </summary>
        public Body Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property Cookies. 
        /// <para>
        /// Inspect the request cookies. You must configure scope and pattern matching filters
        /// in the <c>Cookies</c> object, to define the set of cookies and the parts of the cookies
        /// that WAF inspects. 
        /// </para>
        ///  
        /// <para>
        /// Only the first 8 KB (8192 bytes) of a request's cookies and only the first 200 cookies
        /// are forwarded to WAF for inspection by the underlying host service. You must configure
        /// how to handle any oversize cookie content in the <c>Cookies</c> object. WAF applies
        /// the pattern matching filters to the cookies that it receives from the underlying host
        /// service. 
        /// </para>
        /// </summary>
        public Cookies Cookies { get; set; }

        /// <summary>
        /// Checks to see if the Cookies property is set.
        /// </summary>
        internal bool IsSetCookies() => this.Cookies != null;

        /// <summary>
        /// Gets and sets the property HeaderOrder. 
        /// <para>
        /// Inspect a string containing the list of the request's header names, ordered as they
        /// appear in the web request that WAF receives for inspection. WAF generates the string
        /// and then uses that as the field to match component in its inspection. WAF separates
        /// the header names in the string using colons and no added spaces, for example <c>host:user-agent:accept:authorization:referer</c>.
        /// </para>
        /// </summary>
        public HeaderOrder HeaderOrder { get; set; }

        /// <summary>
        /// Checks to see if the HeaderOrder property is set.
        /// </summary>
        internal bool IsSetHeaderOrder() => this.HeaderOrder != null;

        /// <summary>
        /// Gets and sets the property Headers. 
        /// <para>
        /// Inspect the request headers. You must configure scope and pattern matching filters
        /// in the <c>Headers</c> object, to define the set of headers to and the parts of the
        /// headers that WAF inspects. 
        /// </para>
        ///  
        /// <para>
        /// Only the first 8 KB (8192 bytes) of a request's headers and only the first 200 headers
        /// are forwarded to WAF for inspection by the underlying host service. You must configure
        /// how to handle any oversize header content in the <c>Headers</c> object. WAF applies
        /// the pattern matching filters to the headers that it receives from the underlying host
        /// service. 
        /// </para>
        /// </summary>
        public Headers Headers { get; set; }

        /// <summary>
        /// Checks to see if the Headers property is set.
        /// </summary>
        internal bool IsSetHeaders() => this.Headers != null;

        /// <summary>
        /// Gets and sets the property JA3Fingerprint. 
        /// <para>
        /// Available for use with Amazon CloudFront distributions and Application Load Balancers.
        /// Match against the request's JA3 fingerprint. The JA3 fingerprint is a 32-character
        /// hash derived from the TLS Client Hello of an incoming request. This fingerprint serves
        /// as a unique identifier for the client's TLS configuration. WAF calculates and logs
        /// this fingerprint for each request that has enough TLS Client Hello information for
        /// the calculation. Almost all web requests include this information.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use this choice only with a string match <c>ByteMatchStatement</c> with the
        /// <c>PositionalConstraint</c> set to <c>EXACTLY</c>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can obtain the JA3 fingerprint for client requests from the web ACL logs. If WAF
        /// is able to calculate the fingerprint, it includes it in the logs. For information
        /// about the logging fields, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html">Log
        /// fields</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// Provide the JA3 fingerprint string from the logs in your string match statement specification,
        /// to match with any future requests that have the same TLS configuration.
        /// </para>
        /// </summary>
        public JA3Fingerprint JA3Fingerprint { get; set; }

        /// <summary>
        /// Checks to see if the JA3Fingerprint property is set.
        /// </summary>
        internal bool IsSetJA3Fingerprint() => this.JA3Fingerprint != null;

        /// <summary>
        /// Gets and sets the property JA4Fingerprint. 
        /// <para>
        /// Available for use with Amazon CloudFront distributions and Application Load Balancers.
        /// Match against the request's JA4 fingerprint. The JA4 fingerprint is a 36-character
        /// hash derived from the TLS Client Hello of an incoming request. This fingerprint serves
        /// as a unique identifier for the client's TLS configuration. WAF calculates and logs
        /// this fingerprint for each request that has enough TLS Client Hello information for
        /// the calculation. Almost all web requests include this information.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use this choice only with a string match <c>ByteMatchStatement</c> with the
        /// <c>PositionalConstraint</c> set to <c>EXACTLY</c>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can obtain the JA4 fingerprint for client requests from the web ACL logs. If WAF
        /// is able to calculate the fingerprint, it includes it in the logs. For information
        /// about the logging fields, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html">Log
        /// fields</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// Provide the JA4 fingerprint string from the logs in your string match statement specification,
        /// to match with any future requests that have the same TLS configuration.
        /// </para>
        /// </summary>
        public JA4Fingerprint JA4Fingerprint { get; set; }

        /// <summary>
        /// Checks to see if the JA4Fingerprint property is set.
        /// </summary>
        internal bool IsSetJA4Fingerprint() => this.JA4Fingerprint != null;

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
        /// WAF does not support inspecting the entire contents of the web request body if the
        /// body exceeds the limit for the resource type. When a web request body is larger than
        /// the limit, the underlying host service only forwards the contents that are within
        /// the limit to WAF for inspection. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Application Load Balancer and AppSync, the limit is fixed at 8 KB (8,192 bytes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For CloudFront, API Gateway, Amazon Cognito, App Runner, and Verified Access, the
        /// default limit is 16 KB (16,384 bytes), and you can increase the limit for each resource
        /// type in the web ACL <c>AssociationConfig</c>, for additional processing fees. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amplify, use the CloudFront limit.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about how to handle oversized request bodies, see the <c>JsonBody</c>
        /// object configuration. 
        /// </para>
        /// </summary>
        public JsonBody JsonBody { get; set; }

        /// <summary>
        /// Checks to see if the JsonBody property is set.
        /// </summary>
        internal bool IsSetJsonBody() => this.JsonBody != null;

        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// Inspect the HTTP method. The method indicates the type of operation that the request
        /// is asking the origin to perform. 
        /// </para>
        /// </summary>
        public Method Method { get; set; }

        /// <summary>
        /// Checks to see if the Method property is set.
        /// </summary>
        internal bool IsSetMethod() => this.Method != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// Inspect the query string. This is the part of a URL that appears after a <c>?</c>
        /// character, if any.
        /// </para>
        /// </summary>
        public QueryString QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property SingleHeader. 
        /// <para>
        /// Inspect a single header. Provide the name of the header to inspect, for example, <c>User-Agent</c>
        /// or <c>Referer</c>. This setting isn't case sensitive.
        /// </para>
        ///  
        /// <para>
        /// Example JSON: <c>"SingleHeader": { "Name": "haystack" }</c> 
        /// </para>
        ///  
        /// <para>
        /// Alternately, you can filter and inspect all headers with the <c>Headers</c> <c>FieldToMatch</c>
        /// setting. 
        /// </para>
        /// </summary>
        public SingleHeader SingleHeader { get; set; }

        /// <summary>
        /// Checks to see if the SingleHeader property is set.
        /// </summary>
        internal bool IsSetSingleHeader() => this.SingleHeader != null;

        /// <summary>
        /// Gets and sets the property SingleQueryArgument. 
        /// <para>
        /// Inspect a single query argument. Provide the name of the query argument to inspect,
        /// such as <i>UserName</i> or <i>SalesRegion</i>. The name can be up to 30 characters
        /// long and isn't case sensitive. 
        /// </para>
        ///  
        /// <para>
        /// Example JSON: <c>"SingleQueryArgument": { "Name": "myArgument" }</c> 
        /// </para>
        /// </summary>
        public SingleQueryArgument SingleQueryArgument { get; set; }

        /// <summary>
        /// Checks to see if the SingleQueryArgument property is set.
        /// </summary>
        internal bool IsSetSingleQueryArgument() => this.SingleQueryArgument != null;

        /// <summary>
        /// Gets and sets the property UriFragment. 
        /// <para>
        /// Inspect fragments of the request URI. You must configure scope and pattern matching
        /// filters in the <c>UriFragment</c> object, to define the fragment of a URI that WAF
        /// inspects. 
        /// </para>
        ///  
        /// <para>
        /// Only the first 8 KB (8192 bytes) of a request's URI fragments and only the first 200
        /// URI fragments are forwarded to WAF for inspection by the underlying host service.
        /// You must configure how to handle any oversize URI fragment content in the <c>UriFragment</c>
        /// object. WAF applies the pattern matching filters to the cookies that it receives from
        /// the underlying host service. 
        /// </para>
        /// </summary>
        public UriFragment UriFragment { get; set; }

        /// <summary>
        /// Checks to see if the UriFragment property is set.
        /// </summary>
        internal bool IsSetUriFragment() => this.UriFragment != null;

        /// <summary>
        /// Gets and sets the property UriPath. 
        /// <para>
        /// Inspect the request URI path. This is the part of the web request that identifies
        /// a resource, for example, <c>/images/daily-ad.jpg</c>.
        /// </para>
        /// </summary>
        public UriPath UriPath { get; set; }

        /// <summary>
        /// Checks to see if the UriPath property is set.
        /// </summary>
        internal bool IsSetUriPath() => this.UriPath != null;
    }
}
