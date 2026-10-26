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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDistribution operation. Creates an Amazon
    /// Lightsail content delivery network (CDN) distribution. <para> A distribution is a
    /// globally distributed network of caching servers that improve the performance of your
    /// website or web application hosted on a Lightsail instance. For more information, see
    /// <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-content-delivery-network-distributions">Content
    /// delivery networks in Amazon Lightsail</a>. </para>
    /// </summary>
    public partial class CreateDistributionRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle ID to use for the distribution.
        /// </para>
        ///  
        /// <para>
        /// A distribution bundle describes the specifications of your distribution, such as the
        /// monthly cost and monthly network transfer quota.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetDistributionBundles</c> action to get a list of distribution bundle
        /// IDs that you can specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property CacheBehaviorSettings. 
        /// <para>
        /// An object that describes the cache behavior settings for the distribution.
        /// </para>
        /// </summary>
        public CacheSettings CacheBehaviorSettings { get; set; }

        /// <summary>
        /// Checks to see if the CacheBehaviorSettings property is set.
        /// </summary>
        internal bool IsSetCacheBehaviorSettings() => this.CacheBehaviorSettings != null;

        /// <summary>
        /// Gets and sets the property CacheBehaviors. 
        /// <para>
        /// An array of objects that describe the per-path cache behavior for the distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheBehaviorPerPath> CacheBehaviors { get; set; } = AWSConfigs.InitializeCollections ? new List<CacheBehaviorPerPath>() : null;

        /// <summary>
        /// Checks to see if the CacheBehaviors property is set.
        /// </summary>
        internal bool IsSetCacheBehaviors() => this.CacheBehaviors != null && (this.CacheBehaviors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the SSL/TLS certificate that you want to attach to the distribution.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetCertificates.html">GetCertificates</a>
        /// action to get a list of certificate names that you can specify.
        /// </para>
        /// </summary>
        public string CertificateName { get; set; }

        /// <summary>
        /// Checks to see if the CertificateName property is set.
        /// </summary>
        internal bool IsSetCertificateName() => this.CertificateName != null;

        /// <summary>
        /// Gets and sets the property CustomErrorResponses. 
        /// <para>
        /// An array of objects that describe the custom error responses for the distribution.
        /// With a custom error response, you can specify the page to return when the origin responds
        /// with a given HTTP error code. You can also specify the HTTP status code to send to
        /// the viewer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DistributionCustomErrorResponse> CustomErrorResponses { get; set; } = AWSConfigs.InitializeCollections ? new List<DistributionCustomErrorResponse>() : null;

        /// <summary>
        /// Checks to see if the CustomErrorResponses property is set.
        /// </summary>
        internal bool IsSetCustomErrorResponses() => this.CustomErrorResponses != null && (this.CustomErrorResponses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultCacheBehavior. 
        /// <para>
        /// An object that describes the default cache behavior for the distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CacheBehavior DefaultCacheBehavior { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCacheBehavior property is set.
        /// </summary>
        internal bool IsSetDefaultCacheBehavior() => this.DefaultCacheBehavior != null;

        /// <summary>
        /// Gets and sets the property DefaultRootObject. 
        /// <para>
        /// The object (for example, <c>index.html</c>) that the distribution returns when a viewer
        /// requests the root URL of the distribution (<c>/</c>) instead of a specific object.
        /// The object that you specify must be available from the origin.
        /// </para>
        /// </summary>
        public string DefaultRootObject { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRootObject property is set.
        /// </summary>
        internal bool IsSetDefaultRootObject() => this.DefaultRootObject != null;

        /// <summary>
        /// Gets and sets the property DistributionName. 
        /// <para>
        /// The name for the distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DistributionName { get; set; }

        /// <summary>
        /// Checks to see if the DistributionName property is set.
        /// </summary>
        internal bool IsSetDistributionName() => this.DistributionName != null;

        /// <summary>
        /// Gets and sets the property EnablePrivateOriginAccess. 
        /// <para>
        /// Specifies whether to enable private origin access for the distribution. With private
        /// origin access, the distribution can serve objects that aren't publicly accessible
        /// from a Lightsail bucket.
        /// </para>
        ///  
        /// <para>
        /// Lightsail grants the distribution permission to read the bucket's objects. Enabling
        /// private origin access doesn't change the bucket's access settings, and you can still
        /// retrieve publicly accessible objects directly from the bucket's endpoint.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can enable private origin access only when the distribution's origin is a Lightsail
        /// bucket. If the origin is another resource type, the request fails.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? EnablePrivateOriginAccess { get; set; }

        /// <summary>
        /// Checks to see if the EnablePrivateOriginAccess property is set.
        /// </summary>
        internal bool IsSetEnablePrivateOriginAccess() => this.EnablePrivateOriginAccess.HasValue;

        /// <summary>
        /// Gets and sets the property EnableWaf. 
        /// <para>
        /// Specifies whether to enable Web Application Firewall (WAF) for the distribution. WAF
        /// inspects viewer requests and blocks requests that match the WAF rule groups that you
        /// enable.
        /// </para>
        ///  
        /// <para>
        /// When you enable WAF without specifying the <c>wafRules</c> parameter, the distribution
        /// has no WAF rule groups enabled and doesn't block any requests.
        /// </para>
        ///  <note> 
        /// <para>
        /// WAF is available only for distributions that use the <c>medium_1_0</c> or <c>large_1_0</c>
        /// bundle.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? EnableWaf { get; set; }

        /// <summary>
        /// Checks to see if the EnableWaf property is set.
        /// </summary>
        internal bool IsSetEnableWaf() => this.EnableWaf.HasValue;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the distribution.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <c>ipv4</c> for IPv4 only, and <c>dualstack</c> for IPv4 and
        /// IPv6.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>dualstack</c>.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// An object that describes the origin resource for the distribution, such as a Lightsail
        /// instance, bucket, or load balancer.
        /// </para>
        ///  
        /// <para>
        /// The distribution pulls, caches, and serves content from the origin.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputOrigin Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the distribution during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>TagResource</c> action to tag a resource after it's created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ViewerMinimumTlsProtocolVersion. 
        /// <para>
        /// The minimum TLS protocol version for the SSL/TLS certificate.
        /// </para>
        /// </summary>
        public ViewerMinimumTlsProtocolVersionEnum ViewerMinimumTlsProtocolVersion { get; set; }

        /// <summary>
        /// Checks to see if the ViewerMinimumTlsProtocolVersion property is set.
        /// </summary>
        internal bool IsSetViewerMinimumTlsProtocolVersion() => this.ViewerMinimumTlsProtocolVersion != null;

        /// <summary>
        /// Gets and sets the property WafRules. 
        /// <para>
        /// An array of objects that describe the WAF rule groups to enable for the distribution.
        /// </para>
        ///  
        /// <para>
        /// The WAF rule groups that you can specify depend on the bundle of the distribution:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>medium_1_0</c> – Supports the <c>AWSManagedRulesCommonRuleSet</c>, <c>AWSManagedRulesKnownBadInputsRuleSet</c>,
        /// and <c>AWSManagedRulesAnonymousIpList</c> rule groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>large_1_0</c> – Supports the rule groups for <c>medium_1_0</c>, plus <c>AWSManagedRulesAdminProtectionRuleSet</c>,
        /// <c>AWSManagedRulesSQLiRuleSet</c>, <c>AWSManagedRulesLinuxRuleSet</c>, <c>AWSManagedRulesUnixRuleSet</c>,
        /// <c>AWSManagedRulesWindowsRuleSet</c>, <c>AWSManagedRulesPHPRuleSet</c>, <c>AWSManagedRulesWordPressRuleSet</c>,
        /// <c>AWSManagedRulesAmazonIpReputationList</c>, <c>AWSManagedRulesATPRuleSet</c>, <c>AWSManagedRulesACFPRuleSet</c>,
        /// and <c>AWSManagedRulesBotControlRuleSet</c> rule groups.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WafRule> WafRules { get; set; } = AWSConfigs.InitializeCollections ? new List<WafRule>() : null;

        /// <summary>
        /// Checks to see if the WafRules property is set.
        /// </summary>
        internal bool IsSetWafRules() => this.WafRules != null && (this.WafRules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
