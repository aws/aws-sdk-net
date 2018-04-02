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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A distribution configuration.
    /// </summary>
    public partial class DistributionConfig
    {
        private Aliases _aliases;
        private CacheBehaviors _cacheBehaviors;
        private string _callerReference;
        private string _comment;
        private CustomErrorResponses _customErrorResponses;
        private DefaultCacheBehavior _defaultCacheBehavior;
        private string _defaultRootObject;
        private bool? _enabled;
        private HttpVersion _httpVersion;
        private bool? _isIPV6Enabled;
        private LoggingConfig _logging;
        private Origins _origins;
        private PriceClass _priceClass;
        private Restrictions _restrictions;
        private ViewerCertificate _viewerCertificate;
        private string _webACLId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DistributionConfig() { }

        /// <summary>
        /// Instantiates DistributionConfig with the parameterized properties
        /// </summary>
        /// <param name="callerReference">A unique value (for example, a date-time stamp) that ensures that the request can't be replayed. If the value of <code>CallerReference</code> is new (regardless of the content of the <code>DistributionConfig</code> object), CloudFront creates a new distribution. If <code>CallerReference</code> is a value you already sent in a previous request to create a distribution, and if the content of the <code>DistributionConfig</code> is identical to the original request (ignoring white space), CloudFront returns the same the response that it returned to the original request. If <code>CallerReference</code> is a value you already sent in a previous request to create a distribution but the content of the <code>DistributionConfig</code> is different from the original request, CloudFront returns a <code>DistributionAlreadyExists</code> error.</param>
        /// <param name="enabled">From this field, you can enable or disable the selected distribution. If you specify <code>false</code> for <code>Enabled</code> but you specify values for <code>Bucket</code> and <code>Prefix</code>, the values are automatically deleted.</param>
        public DistributionConfig(string callerReference, bool enabled)
        {
            _callerReference = callerReference;
            _enabled = enabled;
        }

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// A complex type that contains information about CNAMEs (alternate domain names), if
        /// any, for this distribution.
        /// </para>
        /// </summary>
        public Aliases Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null;
        }

        /// <summary>
        /// Gets and sets the property CacheBehaviors. 
        /// <para>
        /// A complex type that contains zero or more <code>CacheBehavior</code> elements. 
        /// </para>
        /// </summary>
        public CacheBehaviors CacheBehaviors
        {
            get { return this._cacheBehaviors; }
            set { this._cacheBehaviors = value; }
        }

        // Check to see if CacheBehaviors property is set
        internal bool IsSetCacheBehaviors()
        {
            return this._cacheBehaviors != null;
        }

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique value (for example, a date-time stamp) that ensures that the request can't
        /// be replayed.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>CallerReference</code> is new (regardless of the content of
        /// the <code>DistributionConfig</code> object), CloudFront creates a new distribution.
        /// </para>
        ///  
        /// <para>
        /// If <code>CallerReference</code> is a value you already sent in a previous request
        /// to create a distribution, and if the content of the <code>DistributionConfig</code>
        /// is identical to the original request (ignoring white space), CloudFront returns the
        /// same the response that it returned to the original request.
        /// </para>
        ///  
        /// <para>
        /// If <code>CallerReference</code> is a value you already sent in a previous request
        /// to create a distribution but the content of the <code>DistributionConfig</code> is
        /// different from the original request, CloudFront returns a <code>DistributionAlreadyExists</code>
        /// error.
        /// </para>
        /// </summary>
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Any comments you want to include about the distribution.
        /// </para>
        ///  
        /// <para>
        /// If you don't want to specify a comment, include an empty <code>Comment</code> element.
        /// </para>
        ///  
        /// <para>
        /// To delete an existing comment, update the distribution configuration and include an
        /// empty <code>Comment</code> element.
        /// </para>
        ///  
        /// <para>
        /// To add or change a comment, update the distribution configuration and specify the
        /// new comment.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property CustomErrorResponses. 
        /// <para>
        /// A complex type that controls the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Whether CloudFront replaces HTTP status codes in the 4xx and 5xx range with custom
        /// error messages before returning the response to the viewer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// How long CloudFront caches HTTP status codes in the 4xx and 5xx range.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about custom error pages, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/custom-error-pages.html">Customizing
        /// Error Responses</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public CustomErrorResponses CustomErrorResponses
        {
            get { return this._customErrorResponses; }
            set { this._customErrorResponses = value; }
        }

        // Check to see if CustomErrorResponses property is set
        internal bool IsSetCustomErrorResponses()
        {
            return this._customErrorResponses != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultCacheBehavior. 
        /// <para>
        /// A complex type that describes the default cache behavior if you don't specify a <code>CacheBehavior</code>
        /// element or if files don't match any of the values of <code>PathPattern</code> in <code>CacheBehavior</code>
        /// elements. You must create exactly one default cache behavior.
        /// </para>
        /// </summary>
        public DefaultCacheBehavior DefaultCacheBehavior
        {
            get { return this._defaultCacheBehavior; }
            set { this._defaultCacheBehavior = value; }
        }

        // Check to see if DefaultCacheBehavior property is set
        internal bool IsSetDefaultCacheBehavior()
        {
            return this._defaultCacheBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRootObject. 
        /// <para>
        /// The object that you want CloudFront to request from your origin (for example, <code>index.html</code>)
        /// when a viewer requests the root URL for your distribution (<code>http://www.example.com</code>)
        /// instead of an object in your distribution (<code>http://www.example.com/product-description.html</code>).
        /// Specifying a default root object avoids exposing the contents of your distribution.
        /// </para>
        ///  
        /// <para>
        /// Specify only the object name, for example, <code>index.html</code>. Don't add a <code>/</code>
        /// before the object name.
        /// </para>
        ///  
        /// <para>
        /// If you don't want to specify a default root object when you create a distribution,
        /// include an empty <code>DefaultRootObject</code> element.
        /// </para>
        ///  
        /// <para>
        /// To delete the default root object from an existing distribution, update the distribution
        /// configuration and include an empty <code>DefaultRootObject</code> element.
        /// </para>
        ///  
        /// <para>
        /// To replace the default root object, update the distribution configuration and specify
        /// the new object.
        /// </para>
        ///  
        /// <para>
        /// For more information about the default root object, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/DefaultRootObject.html">Creating
        /// a Default Root Object</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public string DefaultRootObject
        {
            get { return this._defaultRootObject; }
            set { this._defaultRootObject = value; }
        }

        // Check to see if DefaultRootObject property is set
        internal bool IsSetDefaultRootObject()
        {
            return this._defaultRootObject != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// From this field, you can enable or disable the selected distribution.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>false</code> for <code>Enabled</code> but you specify values
        /// for <code>Bucket</code> and <code>Prefix</code>, the values are automatically deleted.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HttpVersion. 
        /// <para>
        /// (Optional) Specify the maximum HTTP version that you want viewers to use to communicate
        /// with CloudFront. The default value for new web distributions is http2. Viewers that
        /// don't support HTTP/2 automatically use an earlier HTTP version.
        /// </para>
        ///  
        /// <para>
        /// For viewers and CloudFront to use HTTP/2, viewers must support TLS 1.2 or later, and
        /// must support Server Name Identification (SNI).
        /// </para>
        ///  
        /// <para>
        /// In general, configuring CloudFront to communicate with viewers using HTTP/2 reduces
        /// latency. You can improve performance by optimizing for HTTP/2. For more information,
        /// do an Internet search for "http/2 optimization." 
        /// </para>
        /// </summary>
        public HttpVersion HttpVersion
        {
            get { return this._httpVersion; }
            set { this._httpVersion = value; }
        }

        // Check to see if HttpVersion property is set
        internal bool IsSetHttpVersion()
        {
            return this._httpVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IsIPV6Enabled. 
        /// <para>
        /// If you want CloudFront to respond to IPv6 DNS requests with an IPv6 address for your
        /// distribution, specify <code>true</code>. If you specify <code>false</code>, CloudFront
        /// responds to IPv6 DNS requests with the DNS response code <code>NOERROR</code> and
        /// with no IP addresses. This allows viewers to submit a second request, for an IPv4
        /// address for your distribution. 
        /// </para>
        ///  
        /// <para>
        /// In general, you should enable IPv6 if you have users on IPv6 networks who want to
        /// access your content. However, if you're using signed URLs or signed cookies to restrict
        /// access to your content, and if you're using a custom policy that includes the <code>IpAddress</code>
        /// parameter to restrict the IP addresses that can access your content, don't enable
        /// IPv6. If you want to restrict access to some content by IP address and not restrict
        /// access to other content (or restrict access but not by IP address), you can create
        /// two distributions. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-creating-signed-url-custom-policy.html">Creating
        /// a Signed URL Using a Custom Policy</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you're using an Amazon Route 53 alias resource record set to route traffic to your
        /// CloudFront distribution, you need to create a second alias resource record set when
        /// both of the following are true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You enable IPv6 for the distribution
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You're using alternate domain names in the URLs for your objects
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-to-cloudfront-distribution.html">Routing
        /// Traffic to an Amazon CloudFront Web Distribution by Using Your Domain Name</a> in
        /// the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you created a CNAME resource record set, either with Amazon Route 53 or with another
        /// DNS service, you don't need to make any changes. A CNAME record will route traffic
        /// to your distribution regardless of the IP address format of the viewer request.
        /// </para>
        /// </summary>
        public bool IsIPV6Enabled
        {
            get { return this._isIPV6Enabled.GetValueOrDefault(); }
            set { this._isIPV6Enabled = value; }
        }

        // Check to see if IsIPV6Enabled property is set
        internal bool IsSetIsIPV6Enabled()
        {
            return this._isIPV6Enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// A complex type that controls whether access logs are written for the distribution.
        /// </para>
        ///  
        /// <para>
        /// For more information about logging, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/AccessLogs.html">Access
        /// Logs</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public LoggingConfig Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
        }

        /// <summary>
        /// Gets and sets the property Origins. 
        /// <para>
        /// A complex type that contains information about origins for this distribution. 
        /// </para>
        /// </summary>
        public Origins Origins
        {
            get { return this._origins; }
            set { this._origins = value; }
        }

        // Check to see if Origins property is set
        internal bool IsSetOrigins()
        {
            return this._origins != null;
        }

        /// <summary>
        /// Gets and sets the property PriceClass. 
        /// <para>
        /// The price class that corresponds with the maximum price that you want to pay for CloudFront
        /// service. If you specify <code>PriceClass_All</code>, CloudFront responds to requests
        /// for your objects from all CloudFront edge locations.
        /// </para>
        ///  
        /// <para>
        /// If you specify a price class other than <code>PriceClass_All</code>, CloudFront serves
        /// your objects from the CloudFront edge location that has the lowest latency among the
        /// edge locations in your price class. Viewers who are in or near regions that are excluded
        /// from your specified price class may encounter slower performance.
        /// </para>
        ///  
        /// <para>
        /// For more information about price classes, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PriceClass.html">Choosing
        /// the Price Class for a CloudFront Distribution</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>. For information about CloudFront pricing, including how price classes map
        /// to CloudFront regions, see <a href="https://aws.amazon.com/cloudfront/pricing/">Amazon
        /// CloudFront Pricing</a>.
        /// </para>
        /// </summary>
        public PriceClass PriceClass
        {
            get { return this._priceClass; }
            set { this._priceClass = value; }
        }

        // Check to see if PriceClass property is set
        internal bool IsSetPriceClass()
        {
            return this._priceClass != null;
        }

        /// <summary>
        /// Gets and sets the property Restrictions.
        /// </summary>
        public Restrictions Restrictions
        {
            get { return this._restrictions; }
            set { this._restrictions = value; }
        }

        // Check to see if Restrictions property is set
        internal bool IsSetRestrictions()
        {
            return this._restrictions != null;
        }

        /// <summary>
        /// Gets and sets the property ViewerCertificate.
        /// </summary>
        public ViewerCertificate ViewerCertificate
        {
            get { return this._viewerCertificate; }
            set { this._viewerCertificate = value; }
        }

        // Check to see if ViewerCertificate property is set
        internal bool IsSetViewerCertificate()
        {
            return this._viewerCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property WebACLId. 
        /// <para>
        /// A unique identifier that specifies the AWS WAF web ACL, if any, to associate with
        /// this distribution.
        /// </para>
        ///  
        /// <para>
        /// AWS WAF is a web application firewall that lets you monitor the HTTP and HTTPS requests
        /// that are forwarded to CloudFront, and lets you control access to your content. Based
        /// on conditions that you specify, such as the IP addresses that requests originate from
        /// or the values of query strings, CloudFront responds to requests either with the requested
        /// content or with an HTTP 403 status code (Forbidden). You can also configure CloudFront
        /// to return a custom error page when a request is blocked. For more information about
        /// AWS WAF, see the <a href="http://docs.aws.amazon.com/waf/latest/developerguide/what-is-aws-waf.html">AWS
        /// WAF Developer Guide</a>. 
        /// </para>
        /// </summary>
        public string WebACLId
        {
            get { return this._webACLId; }
            set { this._webACLId = value; }
        }

        // Check to see if WebACLId property is set
        internal bool IsSetWebACLId()
        {
            return this._webACLId != null;
        }

    }
}