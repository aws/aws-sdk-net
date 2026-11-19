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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A summary of the information about a CloudFront distribution.
    /// </summary>
    public partial class DistributionSummary
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DistributionSummary() { }

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the distribution. For example: <c>arn:aws:cloudfront::123456789012:distribution/EDFDVBD632BHDS5</c>,
        /// where <c>123456789012</c> is your Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AliasICPRecordal> AliasICPRecordals { get; set; } = AWSConfigs.InitializeCollections ? new List<AliasICPRecordal>() : null;

        /// <summary>
        /// Checks to see if the AliasICPRecordals property is set.
        /// </summary>
        internal bool IsSetAliasICPRecordals() => this.AliasICPRecordals != null && (this.AliasICPRecordals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// A complex type that contains information about CNAMEs (alternate domain names), if
        /// any, for this distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Aliases Aliases { get; set; }

        /// <summary>
        /// Checks to see if the Aliases property is set.
        /// </summary>
        internal bool IsSetAliases() => this.Aliases != null;

        /// <summary>
        /// Gets and sets the property AnycastIpListId. 
        /// <para>
        /// ID of the Anycast static IP list that is associated with the distribution.
        /// </para>
        /// </summary>
        public string AnycastIpListId { get; set; }

        /// <summary>
        /// Checks to see if the AnycastIpListId property is set.
        /// </summary>
        internal bool IsSetAnycastIpListId() => this.AnycastIpListId != null;

        /// <summary>
        /// Gets and sets the property CacheBehaviors. 
        /// <para>
        /// A complex type that contains zero or more <c>CacheBehavior</c> elements.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CacheBehaviors CacheBehaviors { get; set; }

        /// <summary>
        /// Checks to see if the CacheBehaviors property is set.
        /// </summary>
        internal bool IsSetCacheBehaviors() => this.CacheBehaviors != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The comment originally specified when this distribution was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property ConnectionFunctionAssociation. 
        /// <para>
        /// The distribution's connection function association.
        /// </para>
        /// </summary>
        public ConnectionFunctionAssociation ConnectionFunctionAssociation { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionFunctionAssociation property is set.
        /// </summary>
        internal bool IsSetConnectionFunctionAssociation() => this.ConnectionFunctionAssociation != null;

        /// <summary>
        /// Gets and sets the property ConnectionMode. 
        /// <para>
        /// This field specifies whether the connection mode is through a standard distribution
        /// (direct) or a multi-tenant distribution with distribution tenants (tenant-only).
        /// </para>
        /// </summary>
        public ConnectionMode ConnectionMode { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionMode property is set.
        /// </summary>
        internal bool IsSetConnectionMode() => this.ConnectionMode != null;

        /// <summary>
        /// Gets and sets the property CustomErrorResponses. 
        /// <para>
        /// A complex type that contains zero or more <c>CustomErrorResponses</c> elements.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomErrorResponses CustomErrorResponses { get; set; }

        /// <summary>
        /// Checks to see if the CustomErrorResponses property is set.
        /// </summary>
        internal bool IsSetCustomErrorResponses() => this.CustomErrorResponses != null;

        /// <summary>
        /// Gets and sets the property DefaultCacheBehavior. 
        /// <para>
        /// A complex type that describes the default cache behavior if you don't specify a <c>CacheBehavior</c>
        /// element or if files don't match any of the values of <c>PathPattern</c> in <c>CacheBehavior</c>
        /// elements. You must create exactly one default cache behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DefaultCacheBehavior DefaultCacheBehavior { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCacheBehavior property is set.
        /// </summary>
        internal bool IsSetDefaultCacheBehavior() => this.DefaultCacheBehavior != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name that corresponds to the distribution, for example, <c>d111111abcdef8.cloudfront.net</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current version of the distribution.
        /// </para>
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the distribution is enabled to accept user requests for content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property HttpVersion. 
        /// <para>
        /// Specify the maximum HTTP version that you want viewers to use to communicate with
        /// CloudFront. The default value for new web distributions is <c>http2</c>. Viewers that
        /// don't support <c>HTTP/2</c> will automatically use an earlier version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HttpVersion HttpVersion { get; set; }

        /// <summary>
        /// Checks to see if the HttpVersion property is set.
        /// </summary>
        internal bool IsSetHttpVersion() => this.HttpVersion != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the distribution. For example: <c>EDFDVBD632BHDS5</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IsIPV6Enabled. 
        /// <para>
        /// Whether CloudFront responds to IPv6 DNS requests with an IPv6 address for your distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IsIPV6Enabled { get; set; }

        /// <summary>
        /// Checks to see if the IsIPV6Enabled property is set.
        /// </summary>
        internal bool IsSetIsIPV6Enabled() => this.IsIPV6Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the distribution was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OriginGroups. 
        /// <para>
        /// A complex type that contains information about origin groups for this distribution.
        /// </para>
        /// </summary>
        public OriginGroups OriginGroups { get; set; }

        /// <summary>
        /// Checks to see if the OriginGroups property is set.
        /// </summary>
        internal bool IsSetOriginGroups() => this.OriginGroups != null;

        /// <summary>
        /// Gets and sets the property Origins. 
        /// <para>
        /// A complex type that contains information about origins for this distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Origins Origins { get; set; }

        /// <summary>
        /// Checks to see if the Origins property is set.
        /// </summary>
        internal bool IsSetOrigins() => this.Origins != null;

        /// <summary>
        /// Gets and sets the property PriceClass. <note> 
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
        /// </summary>
        [AWSProperty(Required = true)]
        public PriceClass PriceClass { get; set; }

        /// <summary>
        /// Checks to see if the PriceClass property is set.
        /// </summary>
        internal bool IsSetPriceClass() => this.PriceClass != null;

        /// <summary>
        /// Gets and sets the property Restrictions. 
        /// <para>
        /// A complex type that identifies ways in which you want to restrict distribution of
        /// your content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Restrictions Restrictions { get; set; }

        /// <summary>
        /// Checks to see if the Restrictions property is set.
        /// </summary>
        internal bool IsSetRestrictions() => this.Restrictions != null;

        /// <summary>
        /// Gets and sets the property Staging. 
        /// <para>
        /// A Boolean that indicates whether this is a staging distribution. When this value is
        /// <c>true</c>, this is a staging distribution. When this value is <c>false</c>, this
        /// is not a staging distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Staging { get; set; }

        /// <summary>
        /// Checks to see if the Staging property is set.
        /// </summary>
        internal bool IsSetStaging() => this.Staging.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the distribution. When the status is <c>Deployed</c>, the distribution's
        /// information is propagated to all CloudFront edge locations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ViewerCertificate. 
        /// <para>
        /// A complex type that determines the distribution's SSL/TLS configuration for communicating
        /// with viewers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ViewerCertificate ViewerCertificate { get; set; }

        /// <summary>
        /// Checks to see if the ViewerCertificate property is set.
        /// </summary>
        internal bool IsSetViewerCertificate() => this.ViewerCertificate != null;

        /// <summary>
        /// Gets and sets the property ViewerMtlsConfig. 
        /// <para>
        /// The distribution's viewer mTLS configuration.
        /// </para>
        /// </summary>
        public ViewerMtlsConfig ViewerMtlsConfig { get; set; }

        /// <summary>
        /// Checks to see if the ViewerMtlsConfig property is set.
        /// </summary>
        internal bool IsSetViewerMtlsConfig() => this.ViewerMtlsConfig != null;

        /// <summary>
        /// Gets and sets the property WebACLId. 
        /// <para>
        /// The Web ACL Id (if any) associated with the distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WebACLId { get; set; }

        /// <summary>
        /// Checks to see if the WebACLId property is set.
        /// </summary>
        internal bool IsSetWebACLId() => this.WebACLId != null;
    }
}
