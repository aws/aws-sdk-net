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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The processing guidance for a <a>Rule</a>, used by WAF to determine whether a web
    /// request matches the rule. 
    /// 
    ///  
    /// <para>
    /// For example specifications, see the examples section of <a>CreateWebACL</a>.
    /// </para>
    /// </summary>
    public partial class Statement
    {
        private AndStatement _andStatement;
        private AsnMatchStatement _asnMatchStatement;
        private ByteMatchStatement _byteMatchStatement;
        private GeoMatchStatement _geoMatchStatement;
        private IPSetReferenceStatement _ipSetReferenceStatement;
        private LabelMatchStatement _labelMatchStatement;
        private ManagedRuleGroupStatement _managedRuleGroupStatement;
        private NotStatement _notStatement;
        private OrStatement _orStatement;
        private RateBasedStatement _rateBasedStatement;
        private RegexMatchStatement _regexMatchStatement;
        private RegexPatternSetReferenceStatement _regexPatternSetReferenceStatement;
        private RuleGroupReferenceStatement _ruleGroupReferenceStatement;
        private SizeConstraintStatement _sizeConstraintStatement;
        private SqliMatchStatement _sqliMatchStatement;
        private XssMatchStatement _xssMatchStatement;

        /// <summary>
        /// Gets and sets the property AndStatement. 
        /// <para>
        /// A logical rule statement used to combine other rule statements with AND logic. You
        /// provide more than one <a>Statement</a> within the <c>AndStatement</c>. 
        /// </para>
        /// </summary>
        public AndStatement AndStatement
        {
            get { return this._andStatement; }
            set { this._andStatement = value; }
        }

        // Check to see if AndStatement property is set
        internal bool IsSetAndStatement()
        {
            return this._andStatement != null;
        }

        /// <summary>
        /// Gets and sets the property AsnMatchStatement. 
        /// <para>
        /// A rule statement that inspects web traffic based on the Autonomous System Number (ASN)
        /// associated with the request's IP address.
        /// </para>
        ///  
        /// <para>
        /// For additional details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-type-asn-match.html">ASN
        /// match rule statement</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
        /// Developer Guide</a>. 
        /// </para>
        /// </summary>
        public AsnMatchStatement AsnMatchStatement
        {
            get { return this._asnMatchStatement; }
            set { this._asnMatchStatement = value; }
        }

        // Check to see if AsnMatchStatement property is set
        internal bool IsSetAsnMatchStatement()
        {
            return this._asnMatchStatement != null;
        }

        /// <summary>
        /// Gets and sets the property ByteMatchStatement. 
        /// <para>
        /// A rule statement that defines a string match search for WAF to apply to web requests.
        /// The byte match statement provides the bytes to search for, the location in requests
        /// that you want WAF to search, and other settings. The bytes to search for are typically
        /// a string that corresponds with ASCII characters. In the WAF console and the developer
        /// guide, this is called a string match statement.
        /// </para>
        /// </summary>
        public ByteMatchStatement ByteMatchStatement
        {
            get { return this._byteMatchStatement; }
            set { this._byteMatchStatement = value; }
        }

        // Check to see if ByteMatchStatement property is set
        internal bool IsSetByteMatchStatement()
        {
            return this._byteMatchStatement != null;
        }

        /// <summary>
        /// Gets and sets the property GeoMatchStatement. 
        /// <para>
        /// A rule statement that labels web requests by country and region and that matches against
        /// web requests based on country code. A geo match rule labels every request that it
        /// inspects regardless of whether it finds a match.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To manage requests only by country, you can use this statement by itself and specify
        /// the countries that you want to match against in the <c>CountryCodes</c> array. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Otherwise, configure your geo match rule with Count action so that it only labels
        /// requests. Then, add one or more label match rules to run after the geo match rule
        /// and configure them to match against the geographic labels and handle the requests
        /// as needed. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// WAF labels requests using the alpha-2 country and region codes from the International
        /// Organization for Standardization (ISO) 3166 standard. WAF determines the codes using
        /// either the IP address in the web request origin or, if you specify it, the address
        /// in the geo match <c>ForwardedIPConfig</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you use the web request origin, the label formats are <c>awswaf:clientip:geo:region:&lt;ISO
        /// country code&gt;-&lt;ISO region code&gt;</c> and <c>awswaf:clientip:geo:country:&lt;ISO
        /// country code&gt;</c>.
        /// </para>
        ///  
        /// <para>
        /// If you use a forwarded IP address, the label formats are <c>awswaf:forwardedip:geo:region:&lt;ISO
        /// country code&gt;-&lt;ISO region code&gt;</c> and <c>awswaf:forwardedip:geo:country:&lt;ISO
        /// country code&gt;</c>.
        /// </para>
        ///  
        /// <para>
        /// For additional details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rule-statement-type-geo-match.html">Geographic
        /// match rule statement</a> in the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF
        /// Developer Guide</a>. 
        /// </para>
        /// </summary>
        public GeoMatchStatement GeoMatchStatement
        {
            get { return this._geoMatchStatement; }
            set { this._geoMatchStatement = value; }
        }

        // Check to see if GeoMatchStatement property is set
        internal bool IsSetGeoMatchStatement()
        {
            return this._geoMatchStatement != null;
        }

        /// <summary>
        /// Gets and sets the property IPSetReferenceStatement. 
        /// <para>
        /// A rule statement used to detect web requests coming from particular IP addresses or
        /// address ranges. To use this, create an <a>IPSet</a> that specifies the addresses you
        /// want to detect, then use the ARN of that set in this statement. To create an IP set,
        /// see <a>CreateIPSet</a>.
        /// </para>
        ///  
        /// <para>
        /// Each IP set rule statement references an IP set. You create and maintain the set independent
        /// of your rules. This allows you to use the single set in multiple rules. When you update
        /// the referenced set, WAF automatically updates all rules that reference it.
        /// </para>
        /// </summary>
        public IPSetReferenceStatement IPSetReferenceStatement
        {
            get { return this._ipSetReferenceStatement; }
            set { this._ipSetReferenceStatement = value; }
        }

        // Check to see if IPSetReferenceStatement property is set
        internal bool IsSetIPSetReferenceStatement()
        {
            return this._ipSetReferenceStatement != null;
        }

        /// <summary>
        /// Gets and sets the property LabelMatchStatement. 
        /// <para>
        /// A rule statement to match against labels that have been added to the web request by
        /// rules that have already run in the web ACL. 
        /// </para>
        ///  
        /// <para>
        /// The label match statement provides the label or namespace string to search for. The
        /// label string can represent a part or all of the fully qualified label name that had
        /// been added to the web request. Fully qualified labels have a prefix, optional namespaces,
        /// and label name. The prefix identifies the rule group or web ACL context of the rule
        /// that added the label. If you do not provide the fully qualified name in your label
        /// match string, WAF performs the search for labels that were added in the same context
        /// as the label match statement. 
        /// </para>
        /// </summary>
        public LabelMatchStatement LabelMatchStatement
        {
            get { return this._labelMatchStatement; }
            set { this._labelMatchStatement = value; }
        }

        // Check to see if LabelMatchStatement property is set
        internal bool IsSetLabelMatchStatement()
        {
            return this._labelMatchStatement != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedRuleGroupStatement. 
        /// <para>
        /// A rule statement used to run the rules that are defined in a managed rule group. To
        /// use this, provide the vendor name and the name of the rule group in this statement.
        /// You can retrieve the required names by calling <a>ListAvailableManagedRuleGroups</a>.
        /// </para>
        ///  
        /// <para>
        /// You cannot nest a <c>ManagedRuleGroupStatement</c>, for example for use inside a <c>NotStatement</c>
        /// or <c>OrStatement</c>. You cannot use a managed rule group inside another rule group.
        /// You can only reference a managed rule group as a top-level statement within a rule
        /// that you define in a web ACL.
        /// </para>
        ///  <note> 
        /// <para>
        /// You are charged additional fees when you use the WAF Bot Control managed rule group
        /// <c>AWSManagedRulesBotControlRuleSet</c>, the WAF Fraud Control account takeover prevention
        /// (ATP) managed rule group <c>AWSManagedRulesATPRuleSet</c>, or the WAF Fraud Control
        /// account creation fraud prevention (ACFP) managed rule group <c>AWSManagedRulesACFPRuleSet</c>.
        /// For more information, see <a href="http://aws.amazon.com/waf/pricing/">WAF Pricing</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public ManagedRuleGroupStatement ManagedRuleGroupStatement
        {
            get { return this._managedRuleGroupStatement; }
            set { this._managedRuleGroupStatement = value; }
        }

        // Check to see if ManagedRuleGroupStatement property is set
        internal bool IsSetManagedRuleGroupStatement()
        {
            return this._managedRuleGroupStatement != null;
        }

        /// <summary>
        /// Gets and sets the property NotStatement. 
        /// <para>
        /// A logical rule statement used to negate the results of another rule statement. You
        /// provide one <a>Statement</a> within the <c>NotStatement</c>.
        /// </para>
        /// </summary>
        public NotStatement NotStatement
        {
            get { return this._notStatement; }
            set { this._notStatement = value; }
        }

        // Check to see if NotStatement property is set
        internal bool IsSetNotStatement()
        {
            return this._notStatement != null;
        }

        /// <summary>
        /// Gets and sets the property OrStatement. 
        /// <para>
        /// A logical rule statement used to combine other rule statements with OR logic. You
        /// provide more than one <a>Statement</a> within the <c>OrStatement</c>. 
        /// </para>
        /// </summary>
        public OrStatement OrStatement
        {
            get { return this._orStatement; }
            set { this._orStatement = value; }
        }

        // Check to see if OrStatement property is set
        internal bool IsSetOrStatement()
        {
            return this._orStatement != null;
        }

        /// <summary>
        /// Gets and sets the property RateBasedStatement. 
        /// <para>
        /// A rate-based rule counts incoming requests and rate limits requests when they are
        /// coming at too fast a rate. The rule categorizes requests according to your aggregation
        /// criteria, collects them into aggregation instances, and counts and rate limits the
        /// requests for each instance. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you change any of these settings in a rule that's currently in use, the change
        /// resets the rule's rate limiting counts. This can pause the rule's rate limiting activities
        /// for up to a minute. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can specify individual aggregation keys, like IP address or HTTP method. You can
        /// also specify aggregation key combinations, like IP address and HTTP method, or HTTP
        /// method, query argument, and cookie. 
        /// </para>
        ///  
        /// <para>
        /// Each unique set of values for the aggregation keys that you specify is a separate
        /// aggregation instance, with the value from each key contributing to the aggregation
        /// instance definition. 
        /// </para>
        ///  
        /// <para>
        /// For example, assume the rule evaluates web requests with the following IP address
        /// and HTTP method values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// IP address 10.1.1.1, HTTP method POST
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IP address 10.1.1.1, HTTP method GET
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IP address 127.0.0.0, HTTP method POST
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IP address 10.1.1.1, HTTP method GET
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The rule would create different aggregation instances according to your aggregation
        /// criteria, for example: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the aggregation criteria is just the IP address, then each individual address is
        /// an aggregation instance, and WAF counts requests separately for each. The aggregation
        /// instances and request counts for our example would be the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// IP address 10.1.1.1: count 3
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IP address 127.0.0.0: count 1
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If the aggregation criteria is HTTP method, then each individual HTTP method is an
        /// aggregation instance. The aggregation instances and request counts for our example
        /// would be the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// HTTP method POST: count 2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTP method GET: count 2
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If the aggregation criteria is IP address and HTTP method, then each IP address and
        /// each HTTP method would contribute to the combined aggregation instance. The aggregation
        /// instances and request counts for our example would be the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// IP address 10.1.1.1, HTTP method POST: count 1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IP address 10.1.1.1, HTTP method GET: count 2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IP address 127.0.0.0, HTTP method POST: count 1
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For any n-tuple of aggregation keys, each unique combination of values for the keys
        /// defines a separate aggregation instance, which WAF counts and rate-limits individually.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can optionally nest another statement inside the rate-based statement, to narrow
        /// the scope of the rule so that it only counts and rate limits requests that match the
        /// nested statement. You can use this nested scope-down statement in conjunction with
        /// your aggregation key specifications or you can just count and rate limit all requests
        /// that match the scope-down statement, without additional aggregation. When you choose
        /// to just manage all requests that match a scope-down statement, the aggregation instance
        /// is singular for the rule. 
        /// </para>
        ///  
        /// <para>
        /// You cannot nest a <c>RateBasedStatement</c> inside another statement, for example
        /// inside a <c>NotStatement</c> or <c>OrStatement</c>. You can define a <c>RateBasedStatement</c>
        /// inside a web ACL and inside a rule group. 
        /// </para>
        ///  
        /// <para>
        /// For additional information about the options, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-rate-based-rules.html">Rate
        /// limiting web requests using rate-based rules</a> in the <i>WAF Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you only aggregate on the individual IP address or forwarded IP address, you can
        /// retrieve the list of IP addresses that WAF is currently rate limiting for a rule through
        /// the API call <c>GetRateBasedStatementManagedKeys</c>. This option is not available
        /// for other aggregation configurations.
        /// </para>
        ///  
        /// <para>
        /// WAF tracks and manages web requests separately for each instance of a rate-based rule
        /// that you use. For example, if you provide the same rate-based rule settings in two
        /// web ACLs, each of the two rule statements represents a separate instance of the rate-based
        /// rule and gets its own tracking and management by WAF. If you define a rate-based rule
        /// inside a rule group, and then use that rule group in multiple places, each use creates
        /// a separate instance of the rate-based rule that gets its own tracking and management
        /// by WAF. 
        /// </para>
        /// </summary>
        public RateBasedStatement RateBasedStatement
        {
            get { return this._rateBasedStatement; }
            set { this._rateBasedStatement = value; }
        }

        // Check to see if RateBasedStatement property is set
        internal bool IsSetRateBasedStatement()
        {
            return this._rateBasedStatement != null;
        }

        /// <summary>
        /// Gets and sets the property RegexMatchStatement. 
        /// <para>
        /// A rule statement used to search web request components for a match against a single
        /// regular expression. 
        /// </para>
        /// </summary>
        public RegexMatchStatement RegexMatchStatement
        {
            get { return this._regexMatchStatement; }
            set { this._regexMatchStatement = value; }
        }

        // Check to see if RegexMatchStatement property is set
        internal bool IsSetRegexMatchStatement()
        {
            return this._regexMatchStatement != null;
        }

        /// <summary>
        /// Gets and sets the property RegexPatternSetReferenceStatement. 
        /// <para>
        /// A rule statement used to search web request components for matches with regular expressions.
        /// To use this, create a <a>RegexPatternSet</a> that specifies the expressions that you
        /// want to detect, then use the ARN of that set in this statement. A web request matches
        /// the pattern set rule statement if the request component matches any of the patterns
        /// in the set. To create a regex pattern set, see <a>CreateRegexPatternSet</a>.
        /// </para>
        ///  
        /// <para>
        /// Each regex pattern set rule statement references a regex pattern set. You create and
        /// maintain the set independent of your rules. This allows you to use the single set
        /// in multiple rules. When you update the referenced set, WAF automatically updates all
        /// rules that reference it.
        /// </para>
        /// </summary>
        public RegexPatternSetReferenceStatement RegexPatternSetReferenceStatement
        {
            get { return this._regexPatternSetReferenceStatement; }
            set { this._regexPatternSetReferenceStatement = value; }
        }

        // Check to see if RegexPatternSetReferenceStatement property is set
        internal bool IsSetRegexPatternSetReferenceStatement()
        {
            return this._regexPatternSetReferenceStatement != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupReferenceStatement. 
        /// <para>
        /// A rule statement used to run the rules that are defined in a <a>RuleGroup</a>. To
        /// use this, create a rule group with your rules, then provide the ARN of the rule group
        /// in this statement.
        /// </para>
        ///  
        /// <para>
        /// You cannot nest a <c>RuleGroupReferenceStatement</c>, for example for use inside a
        /// <c>NotStatement</c> or <c>OrStatement</c>. You cannot use a rule group reference statement
        /// inside another rule group. You can only reference a rule group as a top-level statement
        /// within a rule that you define in a web ACL.
        /// </para>
        /// </summary>
        public RuleGroupReferenceStatement RuleGroupReferenceStatement
        {
            get { return this._ruleGroupReferenceStatement; }
            set { this._ruleGroupReferenceStatement = value; }
        }

        // Check to see if RuleGroupReferenceStatement property is set
        internal bool IsSetRuleGroupReferenceStatement()
        {
            return this._ruleGroupReferenceStatement != null;
        }

        /// <summary>
        /// Gets and sets the property SizeConstraintStatement. 
        /// <para>
        /// A rule statement that compares a number of bytes against the size of a request component,
        /// using a comparison operator, such as greater than (&gt;) or less than (&lt;). For
        /// example, you can use a size constraint statement to look for query strings that are
        /// longer than 100 bytes. 
        /// </para>
        ///  
        /// <para>
        /// If you configure WAF to inspect the request body, WAF inspects only the number of
        /// bytes in the body up to the limit for the web ACL and protected resource type. If
        /// you know that the request body for your web requests should never exceed the inspection
        /// limit, you can use a size constraint statement to block requests that have a larger
        /// request body size. For more information about the inspection limits, see <c>Body</c>
        /// and <c>JsonBody</c> settings for the <c>FieldToMatch</c> data type. 
        /// </para>
        ///  
        /// <para>
        /// If you choose URI for the value of Part of the request to filter on, the slash (/)
        /// in the URI counts as one character. For example, the URI <c>/logo.jpg</c> is nine
        /// characters long.
        /// </para>
        /// </summary>
        public SizeConstraintStatement SizeConstraintStatement
        {
            get { return this._sizeConstraintStatement; }
            set { this._sizeConstraintStatement = value; }
        }

        // Check to see if SizeConstraintStatement property is set
        internal bool IsSetSizeConstraintStatement()
        {
            return this._sizeConstraintStatement != null;
        }

        /// <summary>
        /// Gets and sets the property SqliMatchStatement. 
        /// <para>
        /// A rule statement that inspects for malicious SQL code. Attackers insert malicious
        /// SQL code into web requests to do things like modify your database or extract data
        /// from it. 
        /// </para>
        /// </summary>
        public SqliMatchStatement SqliMatchStatement
        {
            get { return this._sqliMatchStatement; }
            set { this._sqliMatchStatement = value; }
        }

        // Check to see if SqliMatchStatement property is set
        internal bool IsSetSqliMatchStatement()
        {
            return this._sqliMatchStatement != null;
        }

        /// <summary>
        /// Gets and sets the property XssMatchStatement. 
        /// <para>
        /// A rule statement that inspects for cross-site scripting (XSS) attacks. In XSS attacks,
        /// the attacker uses vulnerabilities in a benign website as a vehicle to inject malicious
        /// client-site scripts into other legitimate web browsers. 
        /// </para>
        /// </summary>
        public XssMatchStatement XssMatchStatement
        {
            get { return this._xssMatchStatement; }
            set { this._xssMatchStatement = value; }
        }

        // Check to see if XssMatchStatement property is set
        internal bool IsSetXssMatchStatement()
        {
            return this._xssMatchStatement != null;
        }

    }
}