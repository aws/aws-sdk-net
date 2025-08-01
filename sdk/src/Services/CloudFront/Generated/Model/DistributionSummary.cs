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
    /// A summary of the information about a CloudFront distribution.
    /// </summary>
    public partial class DistributionSummary
    {
        private Aliases _aliases;
        private List<AliasICPRecordal> _aliasICPRecordals = AWSConfigs.InitializeCollections ? new List<AliasICPRecordal>() : null;
        private string _anycastIpListId;
        private string _arn;
        private CacheBehaviors _cacheBehaviors;
        private string _comment;
        private ConnectionMode _connectionMode;
        private CustomErrorResponses _customErrorResponses;
        private DefaultCacheBehavior _defaultCacheBehavior;
        private string _domainName;
        private bool? _enabled;
        private string _eTag;
        private HttpVersion _httpVersion;
        private string _id;
        private bool? _isIPV6Enabled;
        private DateTime? _lastModifiedTime;
        private OriginGroups _originGroups;
        private Origins _origins;
        private PriceClass _priceClass;
        private Restrictions _restrictions;
        private bool? _staging;
        private string _status;
        private ViewerCertificate _viewerCertificate;
        private string _webACLId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DistributionSummary() { }

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// A complex type that contains information about CNAMEs (alternate domain names), if
        /// any, for this distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AliasICPRecordals. 
        /// <para>
        /// Amazon Web Services services in China customers must file for an Internet Content
        /// Provider (ICP) recordal if they want to serve content publicly on an alternate domain
        /// name, also known as a CNAME, that they've added to CloudFront. AliasICPRecordal provides
        /// the ICP recordal status for CNAMEs associated with distributions.
        /// </para>
        ///  
        /// <para>
        /// For more information about ICP recordals, see <a href="https://docs.amazonaws.cn/en_us/aws/latest/userguide/accounts-and-credentials.html">
        /// Signup, Accounts, and Credentials</a> in <i>Getting Started with Amazon Web Services
        /// services in China</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AliasICPRecordal> AliasICPRecordals
        {
            get { return this._aliasICPRecordals; }
            set { this._aliasICPRecordals = value; }
        }

        // Check to see if AliasICPRecordals property is set
        internal bool IsSetAliasICPRecordals()
        {
            return this._aliasICPRecordals != null && (this._aliasICPRecordals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AnycastIpListId. 
        /// <para>
        /// ID of the Anycast static IP list that is associated with the distribution.
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
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the distribution. For example: <c>arn:aws:cloudfront::123456789012:distribution/EDFDVBD632BHDS5</c>,
        /// where <c>123456789012</c> is your Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CacheBehaviors. 
        /// <para>
        /// A complex type that contains zero or more <c>CacheBehavior</c> elements.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Comment. 
        /// <para>
        /// The comment originally specified when this distribution was created.
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
        /// Gets and sets the property CustomErrorResponses. 
        /// <para>
        /// A complex type that contains zero or more <c>CustomErrorResponses</c> elements.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name that corresponds to the distribution, for example, <c>d111111abcdef8.cloudfront.net</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the distribution is enabled to accept user requests for content.
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
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current version of the distribution.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property HttpVersion. 
        /// <para>
        /// Specify the maximum HTTP version that you want viewers to use to communicate with
        /// CloudFront. The default value for new web distributions is <c>http2</c>. Viewers that
        /// don't support <c>HTTP/2</c> will automatically use an earlier version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the distribution. For example: <c>EDFDVBD632BHDS5</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IsIPV6Enabled. 
        /// <para>
        /// Whether CloudFront responds to IPv6 DNS requests with an IPv6 address for your distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the distribution was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
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
        /// A complex type that contains information about price class for this streaming distribution.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// A Boolean that indicates whether this is a staging distribution. When this value is
        /// <c>true</c>, this is a staging distribution. When this value is <c>false</c>, this
        /// is not a staging distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the distribution. When the status is <c>Deployed</c>, the distribution's
        /// information is propagated to all CloudFront edge locations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ViewerCertificate. 
        /// <para>
        /// A complex type that determines the distribution's SSL/TLS configuration for communicating
        /// with viewers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The Web ACL Id (if any) associated with the distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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