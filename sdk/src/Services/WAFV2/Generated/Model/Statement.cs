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
        /// provide more than one <a>Statement</a> within the <code>AndStatement</code>. 
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
        /// the countries that you want to match against in the <code>CountryCodes</code> array.
        /// 
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
        /// in the geo match <code>ForwardedIPConfig</code>. 
        /// </para>
        ///  
        /// <para>
        /// If you use the web request origin, the label formats are <code>awswaf:clientip:geo:region:&lt;ISO
        /// country code&gt;-&lt;ISO region code&gt;</code> and <code>awswaf:clientip:geo:country:&lt;ISO
        /// country code&gt;</code>.
        /// </para>
        ///  
        /// <para>
        /// If you use a forwarded IP address, the label formats are <code>awswaf:forwardedip:geo:region:&lt;ISO
        /// country code&gt;-&lt;ISO region code&gt;</code> and <code>awswaf:forwardedip:geo:country:&lt;ISO
        /// country code&gt;</code>.
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
        /// You cannot nest a <code>ManagedRuleGroupStatement</code>, for example for use inside
        /// a <code>NotStatement</code> or <code>OrStatement</code>. It can only be referenced
        /// as a top-level statement within a rule.
        /// </para>
        ///  <note> 
        /// <para>
        /// You are charged additional fees when you use the WAF Bot Control managed rule group
        /// <code>AWSManagedRulesBotControlRuleSet</code> or the WAF Fraud Control account takeover
        /// prevention (ATP) managed rule group <code>AWSManagedRulesATPRuleSet</code>. For more
        /// information, see <a href="http://aws.amazon.com/waf/pricing/">WAF Pricing</a>.
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
        /// provide one <a>Statement</a> within the <code>NotStatement</code>.
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
        /// provide more than one <a>Statement</a> within the <code>OrStatement</code>. 
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
        /// A rate-based rule tracks the rate of requests for each originating IP address, and
        /// triggers the rule action when the rate exceeds a limit that you specify on the number
        /// of requests in any 5-minute time span. You can use this to put a temporary block on
        /// requests from an IP address that is sending excessive requests. 
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
        ///  
        /// <para>
        /// When the rule action triggers, WAF blocks additional requests from the IP address
        /// until the request rate falls below the limit.
        /// </para>
        ///  
        /// <para>
        /// You can optionally nest another statement inside the rate-based statement, to narrow
        /// the scope of the rule so that it only counts requests that match the nested statement.
        /// For example, based on recent requests that you have seen from an attacker, you might
        /// create a rate-based rule with a nested AND rule statement that contains the following
        /// nested statements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An IP match statement with an IP set that specifies the address 192.0.2.44.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A string match statement that searches in the User-Agent header for the string BadBot.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In this rate-based rule, you also define a rate limit. For this example, the rate
        /// limit is 1,000. Requests that meet the criteria of both of the nested statements are
        /// counted. If the count exceeds 1,000 requests per five minutes, the rule action triggers.
        /// Requests that do not meet the criteria of both of the nested statements are not counted
        /// towards the rate limit and are not affected by this rule.
        /// </para>
        ///  
        /// <para>
        /// You cannot nest a <code>RateBasedStatement</code> inside another statement, for example
        /// inside a <code>NotStatement</code> or <code>OrStatement</code>. You can define a <code>RateBasedStatement</code>
        /// inside a web ACL and inside a rule group. 
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
        /// You cannot nest a <code>RuleGroupReferenceStatement</code>, for example for use inside
        /// a <code>NotStatement</code> or <code>OrStatement</code>. You can only use a rule group
        /// reference statement at the top level inside a web ACL. 
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
        /// bytes of the body up to the limit for the web ACL. By default, for regional web ACLs,
        /// this limit is 8 KB (8,192 kilobytes) and for CloudFront web ACLs, this limit is 16
        /// KB (16,384 kilobytes). For CloudFront web ACLs, you can increase the limit in the
        /// web ACL <code>AssociationConfig</code>, for additional fees. If you know that the
        /// request body for your web requests should never exceed the inspection limit, you could
        /// use a size constraint statement to block requests that have a larger request body
        /// size.
        /// </para>
        ///  
        /// <para>
        /// If you choose URI for the value of Part of the request to filter on, the slash (/)
        /// in the URI counts as one character. For example, the URI <code>/logo.jpg</code> is
        /// nine characters long.
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