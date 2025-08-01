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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A distribution configuration.
    /// </summary>
    public partial class DistributionConfig
    {
        private Aliases _aliases;
        private string _anycastIpListId;
        private CacheBehaviors _cacheBehaviors;
        private string _callerReference;
        private string _comment;
        private ConnectionMode _connectionMode;
        private string _continuousDeploymentPolicyId;
        private CustomErrorResponses _customErrorResponses;
        private DefaultCacheBehavior _defaultCacheBehavior;
        private string _defaultRootObject;
        private bool? _enabled;
        private HttpVersion _httpVersion;
        private bool? _isIPV6Enabled;
        private LoggingConfig _logging;
        private OriginGroups _originGroups;
        private Origins _origins;
        private PriceClass _priceClass;
        private Restrictions _restrictions;
        private bool? _staging;
        private TenantConfig _tenantConfig;
        private ViewerCertificate _viewerCertificate;
        private string _webACLId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DistributionConfig() { }

        /// <summary>
        /// Instantiates DistributionConfig with the parameterized properties
        /// </summary>
        /// <param name="callerReference">A unique value (for example, a date-time stamp) that ensures that the request can't be replayed. If the value of <c>CallerReference</c> is new (regardless of the content of the <c>DistributionConfig</c> object), CloudFront creates a new distribution. If <c>CallerReference</c> is a value that you already sent in a previous request to create a distribution, CloudFront returns a <c>DistributionAlreadyExists</c> error.</param>
        /// <param name="enabled">From this field, you can enable or disable the selected distribution.</param>
        public DistributionConfig(string callerReference, bool? enabled)
        {
            _callerReference = callerReference;
            _enabled = enabled;
        }

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// <note> 
        /// <para>
        /// This field only supports standard distributions. You can't specify this field for
        /// multi-tenant distributions. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas">Unsupported
        /// features for SaaS Manager for Amazon CloudFront</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// A complex type that contains information about CNAMEs (alternate domain names), if
        /// any, for this distribution.
        /// </para>
        /// 
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
        /// Gets and sets the property AnycastIpListId. 
        /// <para>
        /// <note> 
        /// <para>
        /// To use this field for a multi-tenant distribution, use a connection group instead.
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ConnectionGroup.html">ConnectionGroup</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// ID of the Anycast static IP list that is associated with the distribution.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        public string AnycastIpListId
        {
            get { return this._anycastIpListId; }
            set { this._anycastIpListId = value; }
        }

        // Check to see if AnycastIpListId property is set
        internal bool IsSetAnycastIpListId()
        {
            return this._anycastIpListId != null;
        }

        /// <summary>
        /// Gets and sets the property CacheBehaviors. 
        /// <para>
        /// A complex type that contains zero or more <c>CacheBehavior</c> elements.
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
        /// If the value of <c>CallerReference</c> is new (regardless of the content of the <c>DistributionConfig</c>
        /// object), CloudFront creates a new distribution.
        /// </para>
        ///  
        /// <para>
        /// If <c>CallerReference</c> is a value that you already sent in a previous request to
        /// create a distribution, CloudFront returns a <c>DistributionAlreadyExists</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A comment to describe the distribution. The comment cannot be longer than 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property ConnectionMode. 
        /// <para>
        /// This field specifies whether the connection mode is through a standard distribution
        /// (direct) or a multi-tenant distribution with distribution tenants (tenant-only).
        /// </para>
        /// </summary>
        public ConnectionMode ConnectionMode
        {
            get { return this._connectionMode; }
            set { this._connectionMode = value; }
        }

        // Check to see if ConnectionMode property is set
        internal bool IsSetConnectionMode()
        {
            return this._connectionMode != null;
        }

        /// <summary>
        /// Gets and sets the property ContinuousDeploymentPolicyId. 
        /// <para>
        /// <note> 
        /// <para>
        /// This field only supports standard distributions. You can't specify this field for
        /// multi-tenant distributions. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas">Unsupported
        /// features for SaaS Manager for Amazon CloudFront</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The identifier of a continuous deployment policy. For more information, see <c>CreateContinuousDeploymentPolicy</c>.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        public string ContinuousDeploymentPolicyId
        {
            get { return this._continuousDeploymentPolicyId; }
            set { this._continuousDeploymentPolicyId = value; }
        }

        // Check to see if ContinuousDeploymentPolicyId property is set
        internal bool IsSetContinuousDeploymentPolicyId()
        {
            return this._continuousDeploymentPolicyId != null;
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
        /// For more information about custom error pages, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/custom-error-pages.html">Customizing
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
        /// A complex type that describes the default cache behavior if you don't specify a <c>CacheBehavior</c>
        /// element or if files don't match any of the values of <c>PathPattern</c> in <c>CacheBehavior</c>
        /// elements. You must create exactly one default cache behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// When a viewer requests the root URL for your distribution, the default root object
        /// is the object that you want CloudFront to request from your origin. For example, if
        /// your root URL is <c>https://www.example.com</c>, you can specify CloudFront to return
        /// the <c>index.html</c> file as the default root object. You can specify a default root
        /// object so that viewers see a specific file or object, instead of another object in
        /// your distribution (for example, <c>https://www.example.com/product-description.html</c>).
        /// A default root object avoids exposing the contents of your distribution.
        /// </para>
        ///  
        /// <para>
        /// You can specify the object name or a path to the object name (for example, <c>index.html</c>
        /// or <c>exampleFolderName/index.html</c>). Your string can't begin with a forward slash
        /// (<c>/</c>). Only specify the object name or the path to the object.
        /// </para>
        ///  
        /// <para>
        /// If you don't want to specify a default root object when you create a distribution,
        /// include an empty <c>DefaultRootObject</c> element.
        /// </para>
        ///  
        /// <para>
        /// To delete the default root object from an existing distribution, update the distribution
        /// configuration and include an empty <c>DefaultRootObject</c> element.
        /// </para>
        ///  
        /// <para>
        /// To replace the default root object, update the distribution configuration and specify
        /// the new object.
        /// </para>
        ///  
        /// <para>
        /// For more information about the default root object, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/DefaultRootObject.html">Specify
        /// a default root object</a> in the <i>Amazon CloudFront Developer Guide</i>.
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
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
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
        /// (Optional) Specify the HTTP version(s) that you want viewers to use to communicate
        /// with CloudFront. The default value for new web distributions is <c>http2</c>. Viewers
        /// that don't support HTTP/2 automatically use an earlier HTTP version.
        /// </para>
        ///  
        /// <para>
        /// For viewers and CloudFront to use HTTP/2, viewers must support TLSv1.2 or later, and
        /// must support Server Name Indication (SNI).
        /// </para>
        ///  
        /// <para>
        /// For viewers and CloudFront to use HTTP/3, viewers must support TLSv1.3 and Server
        /// Name Indication (SNI). CloudFront supports HTTP/3 connection migration to allow the
        /// viewer to switch networks without losing connection. For more information about connection
        /// migration, see <a href="https://www.rfc-editor.org/rfc/rfc9000.html#name-connection-migration">Connection
        /// Migration</a> at RFC 9000. For more information about supported TLSv1.3 ciphers, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/secure-connections-supported-viewer-protocols-ciphers.html">Supported
        /// protocols and ciphers between viewers and CloudFront</a>.
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
        /// <note> 
        /// <para>
        /// To use this field for a multi-tenant distribution, use a connection group instead.
        /// For more information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ConnectionGroup.html">ConnectionGroup</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you want CloudFront to respond to IPv6 DNS requests with an IPv6 address for your
        /// distribution, specify <c>true</c>. If you specify <c>false</c>, CloudFront responds
        /// to IPv6 DNS requests with the DNS response code <c>NOERROR</c> and with no IP addresses.
        /// This allows viewers to submit a second request, for an IPv4 address for your distribution.
        /// </para>
        ///  
        /// <para>
        /// In general, you should enable IPv6 if you have users on IPv6 networks who want to
        /// access your content. However, if you're using signed URLs or signed cookies to restrict
        /// access to your content, and if you're using a custom policy that includes the <c>IpAddress</c>
        /// parameter to restrict the IP addresses that can access your content, don't enable
        /// IPv6. If you want to restrict access to some content by IP address and not restrict
        /// access to other content (or restrict access but not by IP address), you can create
        /// two distributions. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/private-content-creating-signed-url-custom-policy.html">Creating
        /// a Signed URL Using a Custom Policy</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you're using an Route 53 Amazon Web Services Integration alias resource record
        /// set to route traffic to your CloudFront distribution, you need to create a second
        /// alias resource record set when both of the following are true:
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
        /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-to-cloudfront-distribution.html">Routing
        /// Traffic to an Amazon CloudFront Web Distribution by Using Your Domain Name</a> in
        /// the <i>Route 53 Amazon Web Services Integration Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you created a CNAME resource record set, either with Route 53 Amazon Web Services
        /// Integration or with another DNS service, you don't need to make any changes. A CNAME
        /// record will route traffic to your distribution regardless of the IP address format
        /// of the viewer request.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        public bool? IsIPV6Enabled
        {
            get { return this._isIPV6Enabled; }
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
        /// For more information about logging, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/AccessLogs.html">Access
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
        /// Gets and sets the property OriginGroups. 
        /// <para>
        /// A complex type that contains information about origin groups for this distribution.
        /// </para>
        /// </summary>
        public OriginGroups OriginGroups
        {
            get { return this._originGroups; }
            set { this._originGroups = value; }
        }

        // Check to see if OriginGroups property is set
        internal bool IsSetOriginGroups()
        {
            return this._originGroups != null;
        }

        /// <summary>
        /// Gets and sets the property Origins. 
        /// <para>
        /// A complex type that contains information about origins for this distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// <note> 
        /// <para>
        /// This field only supports standard distributions. You can't specify this field for
        /// multi-tenant distributions. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas">Unsupported
        /// features for SaaS Manager for Amazon CloudFront</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The price class that corresponds with the maximum price that you want to pay for CloudFront
        /// service. If you specify <c>PriceClass_All</c>, CloudFront responds to requests for
        /// your objects from all CloudFront edge locations.
        /// </para>
        ///  
        /// <para>
        /// If you specify a price class other than <c>PriceClass_All</c>, CloudFront serves your
        /// objects from the CloudFront edge location that has the lowest latency among the edge
        /// locations in your price class. Viewers who are in or near regions that are excluded
        /// from your specified price class may encounter slower performance.
        /// </para>
        ///  
        /// <para>
        /// For more information about price classes, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PriceClass.html">Choosing
        /// the Price Class for a CloudFront Distribution</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>. For information about CloudFront pricing, including how price classes (such
        /// as Price Class 100) map to CloudFront regions, see <a href="http://aws.amazon.com/cloudfront/pricing/">Amazon
        /// CloudFront Pricing</a>.
        /// </para>
        /// 
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
        /// <para>
        /// A complex type that identifies ways in which you want to restrict distribution of
        /// your content.
        /// </para>
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
        /// Gets and sets the property Staging. 
        /// <para>
        /// <note> 
        /// <para>
        /// This field only supports standard distributions. You can't specify this field for
        /// multi-tenant distributions. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas">Unsupported
        /// features for SaaS Manager for Amazon CloudFront</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// A Boolean that indicates whether this is a staging distribution. When this value is
        /// <c>true</c>, this is a staging distribution. When this value is <c>false</c>, this
        /// is not a staging distribution.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        public bool? Staging
        {
            get { return this._staging; }
            set { this._staging = value; }
        }

        // Check to see if Staging property is set
        internal bool IsSetStaging()
        {
            return this._staging.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TenantConfig. 
        /// <para>
        /// <note> 
        /// <para>
        /// This field only supports multi-tenant distributions. You can't specify this field
        /// for standard distributions. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-config-options.html#unsupported-saas">Unsupported
        /// features for SaaS Manager for Amazon CloudFront</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// A distribution tenant configuration.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        public TenantConfig TenantConfig
        {
            get { return this._tenantConfig; }
            set { this._tenantConfig = value; }
        }

        // Check to see if TenantConfig property is set
        internal bool IsSetTenantConfig()
        {
            return this._tenantConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ViewerCertificate. 
        /// <para>
        /// A complex type that determines the distribution's SSL/TLS configuration for communicating
        /// with viewers.
        /// </para>
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
        /// <note> 
        /// <para>
        /// Multi-tenant distributions only support WAF V2 web ACLs.
        /// </para>
        ///  </note> 
        /// <para>
        /// A unique identifier that specifies the WAF web ACL, if any, to associate with this
        /// distribution. To specify a web ACL created using the latest version of WAF, use the
        /// ACL ARN, for example <c>arn:aws:wafv2:us-east-1:123456789012:global/webacl/ExampleWebACL/a1b2c3d4-5678-90ab-cdef-EXAMPLE11111</c>.
        /// To specify a web ACL created using WAF Classic, use the ACL ID, for example <c>a1b2c3d4-5678-90ab-cdef-EXAMPLE11111</c>.
        /// </para>
        ///  
        /// <para>
        /// WAF is a web application firewall that lets you monitor the HTTP and HTTPS requests
        /// that are forwarded to CloudFront, and lets you control access to your content. Based
        /// on conditions that you specify, such as the IP addresses that requests originate from
        /// or the values of query strings, CloudFront responds to requests either with the requested
        /// content or with an HTTP 403 status code (Forbidden). You can also configure CloudFront
        /// to return a custom error page when a request is blocked. For more information about
        /// WAF, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/what-is-aws-waf.html">WAF
        /// Developer Guide</a>.
        /// </para>
        /// 
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